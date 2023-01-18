using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Session_07
{
    public class ActionResolver
    {

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // CTOR
        public ActionResolver()
        {

        }

        // METHODS
        public ActionResponse Execute(ActionRequest request)
        {

            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;

            try //
            {
                switch (request.Action)
                {
                    case ActionEnum.Convert:
                        response.Output = Convert(request.Input);
                        break;
                    case ActionEnum.Uppercase:
                        response.Output = Uppercase(request.Input);
                        break;
                    case ActionEnum.Reverse:
                        response.Output = Reverse(request.Input);
                        break;
                    default:
                        break;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            

                    return response;
        }
        public string Convert(string input)
        {
            return string.Empty;

            
        }

        public string Uppercase(string input)
        {
            // “Uppercase” you must check if the Input is a string and has more than
            // one words(separated by a space), then find the longest word in the
            // Input string and convert it to uppercase.
            return string.Empty;



            return input.ToUpper();
        }

        public string Reverse(string input)
        {
            // “Reverse” you must check if the Input is a string and reverse it.

            return string.Empty;

        }


    }

}
