using Bridge;
using System;
using System.Linq;
using UI5;
using System.Collections.Generic;

namespace ClientScripts
{
    [FileName("model/formatter.js")]
    [Name("manu.toolpageapp.fv.model.Formatter")]
    public class Formatter
    {
        /// <summary>
        /// Gets the path to the image based on the device
        /// </summary>
        /// <param name="bIsPhone">the value to be checked</param>
        /// <returns>path to image</returns>
        public virtual string srcImageValue(bool bIsPhone)
        {
            var sImageSrc = "";
            if (!bIsPhone) {
                sImageSrc = "/images/homeImage.jpg";
            } else {
                sImageSrc = "/images/homeImage_small.jpg";
            }
            return sImageSrc;
        }

        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                },
                new Func<object>(
                    () => {
                        Formatter newObj = Glue.CreateRawClassObject<Formatter>();
                        return newObj;
                    }
                )
            );
        }
    }
}