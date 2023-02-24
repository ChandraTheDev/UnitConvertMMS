using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using UnitConvertMMS.IRepository;

namespace UnitConvertMMS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UnitConverterController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UnitConverterController> _logger;
        public UnitConverterController(IUnitOfWork unitOfWork, ILogger<UnitConverterController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            OperationOrder.Add("/");
            OperationOrder.Add("*");
            OperationOrder.Add("-");
            OperationOrder.Add("+");
        }
        [HttpGet]
        public async Task<IActionResult> ConvertUnits(double InputValue, string FromUnit, string ToUnit)
        {
            try
            {
                var unitRate = _unitOfWork
                                .UnitRates
                                .GetAsync(x => x.MetricUnitName == FromUnit
                                            && x.ImperialUnitName == ToUnit);
                if (unitRate != null)
                {
                    if (string.IsNullOrEmpty(unitRate.Result.Formula))
                    {
                        double outputValue = InputValue * unitRate.Result.RateMetricToImperial;
                        return Ok(InputValue + " " + FromUnit + " is equal to " + outputValue.ToString("N3") + " " + ToUnit);
                    }
                    else
                    {
                        string Formula = unitRate.Result.Formula;
                        Formula = Formula.Replace("X", InputValue.ToString());
                        while (Formula.LastIndexOf("(") > -1)
                        {
                            int lastOpenPhrantesisIndex = Formula.LastIndexOf("(");
                            int firstClosePhrantesisIndexAfterLastOpened = Formula.IndexOf(")", lastOpenPhrantesisIndex);
                            decimal result = ProcessOperation(Formula.Substring(lastOpenPhrantesisIndex + 1, firstClosePhrantesisIndexAfterLastOpened - lastOpenPhrantesisIndex - 1));
                            bool AppendAsterix = false;
                            if (lastOpenPhrantesisIndex > 0)
                            {
                                if (Formula.Substring(lastOpenPhrantesisIndex - 1, 1) != "(" && !OperationOrder.Contains(Formula.Substring(lastOpenPhrantesisIndex - 1, 1)))
                                {
                                    AppendAsterix = true;
                                }
                            }

                            Formula = Formula.Substring(0, lastOpenPhrantesisIndex) + (AppendAsterix ? " " : "") + result.ToString() + Formula.Substring(firstClosePhrantesisIndexAfterLastOpened + 1);
                        }

                        decimal outputValue = ProcessOperation(Formula);
                        return Ok(InputValue + " " + FromUnit + " is equal to " + outputValue.ToString("N3") + " " + ToUnit);
                    }
                }
                else
                    return BadRequest("From unit or To Unit doesn't exist in our database.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Something went wrong");
                return StatusCode(500, "Internal Server Error. Try again later");
            }
        }
        private List<String> OperationOrder = new List<string>();
        private decimal ProcessOperation(string operation)
        {
            ArrayList arr = new ArrayList();
            string s = "";
            for (int i = 0; i < operation.Length; i++)
            {
                string currentCharacter = operation.Substring(i, 1);
                if (OperationOrder.IndexOf(currentCharacter) > -1)
                {
                    if (s != "")
                    {
                        arr.Add(s);
                    }
                    arr.Add(currentCharacter);
                    s = "";
                }
                else
                {
                    s += currentCharacter;
                }
            }
            arr.Add(s);
            s = "";
            foreach (string op in OperationOrder)
            {
                while (arr.IndexOf(op) > -1)
                {
                    int operatorIndex = arr.IndexOf(op);
                    decimal digitBeforeOperator = Convert.ToDecimal(arr[operatorIndex - 1]);
                    decimal digitAfterOperator = 0;
                    if (arr[operatorIndex + 1].ToString() == "-")
                    {
                        arr.RemoveAt(operatorIndex + 1);
                        digitAfterOperator = Convert.ToDecimal(arr[operatorIndex + 1]) * -1;
                    }
                    else
                    {
                        digitAfterOperator = Convert.ToDecimal(arr[operatorIndex + 1]);
                    }
                    arr[operatorIndex] = CalculateByOperator(digitBeforeOperator, digitAfterOperator, op);
                    arr.RemoveAt(operatorIndex - 1);
                    arr.RemoveAt(operatorIndex);
                }
            }
            return Convert.ToDecimal(arr[0]);
        }

        private decimal CalculateByOperator(decimal number1, decimal number2, string op)
        {
            if (op == "/")
            {
                return number1 / number2;
            }
            else if (op == "*")
            {
                return number1 * number2;
            }
            else if (op == "-")
            {
                return number1 - number2;
            }
            else if (op == "+")
            {
                return number1 + number2;
            }
            else
            {
                return 0;
            }
        }

    }
}
