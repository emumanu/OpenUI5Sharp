using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;
using System.Collections.Generic;

namespace ClientScripts
{
    [FileName("controller/BaseController.js")]
    [Name("manu.toolpageapp.fv.controller.BaseController")]
    public class BaseController : sap.ui.core.mvc.Controller
    {
        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "sap/ui/core/mvc/Controller",
                },
                new Func<object>(
                    () => {
                        BaseController newObj = Glue.CreateRawClassObject<BaseController>();
                        return sap.ui.core.mvc.Controller.extend(nameof(BaseController), newObj);
                    }
                )
            );
        }

        public BaseController(Union<string, object[]> sName) : base(sName)
        {
        }

        /// <summary>
        /// Convenience method for accessing the router
        /// </summary>
        /// <returns>the router for this component</returns>
        public virtual sap.ui.core.routing.Router getRouter()
        {
            return sap.ui.core.UIComponent.getRouterFor(this);
    }

        /// <summary>
        /// Convenience method for getting the view model by name
        /// </summary>
        /// <param name="sName">the model name</param>
        /// <returns>the model instance</returns>
        public virtual T getModel<T>(string sName) where T : sap.ui.model.Model
        {
            return this.getView().getModel<T>(sName);
        }

        /// <summary>
        /// Convenience method for getting the strongly view model by name
        /// </summary>
        /// <param name="sName">the model name</param>
        /// <returns>the model instance</returns>
        public virtual sap.ui.model.Model<T> getModelFor<T>(string sName)
        {
            return this.getView().getModelFor<T>(sName);
        }

        /// <summary>
        /// Convenience method for setting the view model.
        /// </summary>
        /// <param name="oModel">the model name</param>
        /// <param name="sName">the model name</param>

        public virtual void setModel(sap.ui.model.Model oModel, string sName)
        {
            this.getView().setModel(oModel, sName);
        }
    }
}