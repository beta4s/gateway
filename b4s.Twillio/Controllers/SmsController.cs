using Microsoft.AspNetCore.Mvc;
using Twilio.AspNet.Core;

namespace b4s.Twillio.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SmsController : TwilioController
    {

        private readonly RabbitMQ.Helper _rabbitmqHelper;

        public SmsController(RabbitMQ.Helper rabbitmqHelper)
        {
            _rabbitmqHelper = rabbitmqHelper;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {

            var from = Request.Form["From"][0];
            var to = Request.Form["To"][0];
            var body = Request.Form["Body"];
            var testContent = $@"<Response><Message>your number:{from} and your message: '{body}'</Message></Response>";

            //var message = new b4s.Message.Model.Message()
            //{ 
                
            //}

            //TwilioClient.Init(
            //               "ACf16b7e49d29bd517f595c93703d34aff",
            //               "fefae054d5a297ae4a6ec9696571641f"
            //           );

            //var message = 
            //    MessageResource.Create(
            //                            from: new PhoneNumber(to),
            //                            to: new PhoneNumber(from),
            //                            body: "Ahoy from Twilio!"
            //                           );

            //return Content(testContent, "text/xml");

            return Ok();

        }

    }

}
