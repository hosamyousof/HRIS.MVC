using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRIS.Web.Framework
{
    public class ModelException : Exception
    {
        private ICollection<ModelState> ModelErrors;

        public ModelException()
        {
            this.ErrorList = new List<string>();
        }

        public ModelException(string message)
            : base(message)
        {
            this.ErrorList = new List<string>();
        }

        public ModelException(string message, Exception inner)
            : base(message, inner)
        {
            this.ErrorList = new List<string>();
        }

        public ModelException(ICollection<ModelState> collection)
        {
            this.ModelErrors = collection;
            this.ModelErrorMessage = "";
            if (this.ErrorList == null) this.ErrorList = new List<string>();
            foreach (var modelState in collection)
            {
                foreach (var error in modelState.Errors)
                {
                    this.ModelErrorMessage += error.ErrorMessage + "<br>";
                    this.ErrorList.Add(error.ErrorMessage);
                }
            }
        }

        public List<string> ErrorList { get; set; }

        public override string Message
        {
            get
            {
                return ModelErrorMessage;
            }
        }

        public string ModelErrorMessage { get; set; }
    }
}