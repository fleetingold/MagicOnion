﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Benchmark.Client
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Benchmark.Client;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class BenchmarkReportPageTemplate : BenchmarkReportPageTemplateBase
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");

    var client = Report.Client;
    var summary = Report.Summary;
    var unaryConnectionsResult = Report.UnaryConnectionsResult;
    var hubConnectionsResult = Report.HubConnectionsResult;

            this.Write(@"
<!-- auto-generated -->
<!DOCTYPE html>
<html lang=""ja"">

<head>
    <meta charset=""utf-8"">
    <title>MagicOnion Benchmark</title>

    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css""
        integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous""/>
    <!-- MDB -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css""/>
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap""/>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/3.0.0/mdb.min.css""/>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.bundle.js""></script>
</head>

<body>
    <header>
        <nav class=""navbar navbar-dark bg-dark box-shadow"">
            <div class=""container d-flex"">
                <a class=""navbar-brand"" href=""#"">MagicOnion Benchmark</a>
                <div class=""collapse navbar-collapse"" id=""navbarText"">
                    <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                    </ul>
                </div>
                <span class=""navbar-text"">");
            this.Write(this.ToStringHelper.ToStringWithCulture(client.Framework));
            this.Write(" v");
            this.Write(this.ToStringHelper.ToStringWithCulture(client.Version));
            this.Write(@"</span>
            </div>
        </nav>
    </header>

    <main>
        <div class=""bg-light"">
            <div class=""container"" style=""padding-top: 3rem;"">

                <h1 class=""text-muted"">Test Result</h1>
                <p class=""text-muted"">Id: ");
            this.Write(this.ToStringHelper.ToStringWithCulture(summary.Id));
            this.Write(@"</p>

                <div class=""table-responsive"">
                    <h2 class=""text-muted"">Client</h2>
                    <table class=""table table-striped table-sm"">
                        <thead>
                            <tr>
                            <th scope=""col"">OS</th>
                            <th scope=""col""># Process</th>
                            <th scope=""col"">Memory</th>
                            </tr>
                        </thead>
                        <tr>
                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(client.Os));
            this.Write(" (");
            this.Write(this.ToStringHelper.ToStringWithCulture(client.Architecture));
            this.Write(")</td>\r\n                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(client.Processors));
            this.Write("</td>\r\n                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(client.Memory));
            this.Write(@"GiB</td>
                        </tr>
                        </tbody>
                    </table>
                </div>

                <div class=""table-responsive"">
                    <h2 class=""text-muted"">Summary</h2>
                    <table class=""table table-striped table-sm"">
                        <thead>
                            <th scope=""col""># Clients</th>
                            <th scope=""col""># Itelations</th>
                            <th scope=""col"">Begin</th>
                            <th scope=""col"">End</th>
                            <th scope=""col"">Duration Total</th>
                            <th scope=""col"">Duration Avg</th>
                            <th scope=""col"">Duration Min</th>
                            <th scope=""col"">Duration Max</th>
                        </thead>
                        <tr>
                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(summary.Clients));
            this.Write("</td>\r\n                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(summary.Itelations));
            this.Write("</td>\r\n                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(summary.Begin));
            this.Write("</td>\r\n                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(summary.End));
            this.Write("</td>\r\n                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("{0:f2}", summary.DurationTotal.TotalSeconds)));
            this.Write(" sec</td>\r\n                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("{0:f2}", summary.DurationAvg.TotalSeconds)));
            this.Write(" sec</td>\r\n                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("{0:f2}", summary.DurationMin.TotalSeconds)));
            this.Write(" sec</td>\r\n                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("{0:f2}", summary.DurationMax.TotalSeconds)));
            this.Write(@" sec</td>
                        </tr>
                        </tbody>
                    </table>
                </div>

                <div class=""table-responsive"">
                    <h2 class=""text-muted"">Unary Connections</h2>
                    <table class=""table table-striped table-sm"">
                        <thead>
                            <th scope=""col"">Requests</th>
                        ");
 foreach(var item in unaryConnectionsResult.SummaryItems) { 
            this.Write("                            <th scope=\"col\">");
            this.Write(this.ToStringHelper.ToStringWithCulture(item.RequestCount));
            this.Write(" con</th>\r\n                        ");
 } 
            this.Write("                            <th scope=\"col\">Errors</th>\r\n                        " +
                    "</thead>\r\n                        <tr>\r\n                            <td>Duration" +
                    "</td>\r\n                        ");
 foreach(var item in unaryConnectionsResult.SummaryItems) { 
            this.Write("                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("{0:f2}", item.Duration.TotalSeconds)));
            this.Write(" sec</td>\r\n                        ");
 } 
            this.Write("                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(unaryConnectionsResult.Errors));
            this.Write("</td>\r\n                        </tr>\r\n                        <tr>\r\n             " +
                    "               <td>Rps</td>\r\n                        ");
 foreach(var item in unaryConnectionsResult.SummaryItems) { 
            this.Write("                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("{0:f2}", item.Rps)));
            this.Write(" rps</td>\r\n                        ");
 } 
            this.Write(@"                        </tr>
                        </tbody>
                    </table>
                </div>

                <div class=""table-responsive"">
                    <h2 class=""text-muted"">Hub Connections</h2>
                    <table class=""table table-striped table-sm"">
                        <thead>
                            <th scope=""col"">Requests</th>
                        ");
 foreach(var item in hubConnectionsResult.SummaryItems) { 
            this.Write("                            <th scope=\"col\">");
            this.Write(this.ToStringHelper.ToStringWithCulture(item.RequestCount));
            this.Write(" con</th>\r\n                        ");
 } 
            this.Write("                            <th scope=\"col\">Errors</th>\r\n                        " +
                    "</thead>\r\n                        <tr>\r\n                            <td>Duration" +
                    "</td>\r\n                        ");
 foreach(var item in hubConnectionsResult.SummaryItems) { 
            this.Write("                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("{0:f2}", item.Duration.TotalSeconds)));
            this.Write(" sec</td>\r\n                        ");
 } 
            this.Write("                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(hubConnectionsResult.Errors));
            this.Write("</td>\r\n                        </tr>\r\n                        <tr>\r\n             " +
                    "               <td>Rps</td>\r\n                        ");
 foreach(var item in hubConnectionsResult.SummaryItems) { 
            this.Write("                            <td>");
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Format("{0:f2}", item.Rps)));
            this.Write(" rps</td>\r\n                        ");
 } 
            this.Write(@"                        </tr>
                        </tbody>
                    </table>
                </div>

                <div>
                    <h2>Unary Connections & Duration</h2>
                    <canvas id=""unaryConnectionStackBar""></canvas>

                    <script>
                        var ctx = document.getElementById(""unaryConnectionStackBar"");
                        var myChart = new Chart(ctx, {
                            type: 'bar',
                            data: {
                                labels: [
                                ");
 foreach(var item in unaryConnectionsResult.SummaryItems) { 
            this.Write("                                    \"");
            this.Write(this.ToStringHelper.ToStringWithCulture(item.RequestCount));
            this.Write("\",\r\n                                ");
 } 
            this.Write("                                ],\r\n                                datasets: [\r\n" +
                    "                                ");
 for(var i = 0; i < unaryConnectionsResult.ClientDurationItems.Length; i++) { 
            this.Write("                                {\r\n                                    ");

                                        var current = unaryConnectionsResult.ClientDurationItems[i];
                                        var items = current.Items;
                                        var color = GetColor(i);
                                    
            this.Write("                                    label: \"");
            this.Write(this.ToStringHelper.ToStringWithCulture(current.Client));
            this.Write("\",\r\n                                    borderWidth: 1,\r\n                        " +
                    "            backgroundColor: \"");
            this.Write(this.ToStringHelper.ToStringWithCulture(color));
            this.Write("\",\r\n                                    borderColor: \"");
            this.Write(this.ToStringHelper.ToStringWithCulture(color));
            this.Write("\",\r\n                                    data: [\r\n                                " +
                    "    ");
 foreach(var item in items) { 
            this.Write("                                        ");
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Duration.TotalSeconds));
            this.Write(",\r\n                                    ");
 } 
            this.Write("                                    ]\r\n                                },\r\n      " +
                    "                          ");
 } 
            this.Write("                                ]\r\n                            },\r\n              " +
                    "              options: {\r\n                                title: {\r\n            " +
                    "                        display: true,\r\n                                    text" +
                    ": \'Unary\',\r\n                                    padding: 3\r\n                    " +
                    "            },\r\n                                scales: {\r\n                     " +
                    "               xAxes: [{\r\n                                        stacked: true," +
                    " // use stacked bar chart\r\n                                        categoryPerce" +
                    "ntage: 0.4 // width of bar\r\n                                    }],\r\n           " +
                    "                         yAxes: [{\r\n                                        stac" +
                    "ked: true // use stacked bar chart\r\n                                    }]\r\n    " +
                    "                            },\r\n                                legend: {\r\n     " +
                    "                               labels: {\r\n                                      " +
                    "  boxWidth: 30,\r\n                                        padding: 20\r\n          " +
                    "                          },\r\n                                    display: true\r" +
                    "\n                                },\r\n                                tooltips: {" +
                    "\r\n                                    mode: \'label\' // data colum for tooltip\r\n " +
                    "                               },\r\n                                responsive: t" +
                    "rue\r\n                            }\r\n                        });\r\n               " +
                    "     </script>\r\n                </div>\r\n\r\n                <div>\r\n               " +
                    "     <h2>Hub Connections & Duration</h2>\r\n                    <canvas id=\"hubCon" +
                    "nectionStackBar\"></canvas>\r\n\r\n                    <script>\r\n                    " +
                    "    var ctx = document.getElementById(\"hubConnectionStackBar\");\r\n               " +
                    "         var myChart = new Chart(ctx, {\r\n                            type: \'bar\'" +
                    ",\r\n                            data: {\r\n                                labels: " +
                    "[\r\n                                ");
 foreach(var item in hubConnectionsResult.SummaryItems) { 
            this.Write("                                    \"");
            this.Write(this.ToStringHelper.ToStringWithCulture(item.RequestCount));
            this.Write("\",\r\n                                ");
 } 
            this.Write("                                ],\r\n                                datasets: [\r\n" +
                    "                                ");
 for(var i = 0; i < hubConnectionsResult.ClientDurationItems.Length; i++) { 
            this.Write("                                {\r\n                                    ");

                                        var current = hubConnectionsResult.ClientDurationItems[i];
                                        var items = current.Items;
                                        var color = GetColor(i);
                                    
            this.Write("                                    label: \"");
            this.Write(this.ToStringHelper.ToStringWithCulture(current.Client));
            this.Write("\",\r\n                                    borderWidth: 1,\r\n                        " +
                    "            backgroundColor: \"");
            this.Write(this.ToStringHelper.ToStringWithCulture(color));
            this.Write("\",\r\n                                    borderColor: \"");
            this.Write(this.ToStringHelper.ToStringWithCulture(color));
            this.Write("\",\r\n                                    data: [\r\n                                " +
                    "    ");
 foreach(var item in items) { 
            this.Write("                                        ");
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Duration.TotalSeconds));
            this.Write(",\r\n                                    ");
 } 
            this.Write("                                    ]\r\n                                },\r\n      " +
                    "                          ");
 } 
            this.Write("                                ]\r\n                            },\r\n              " +
                    "              options: {\r\n                                title: {\r\n            " +
                    "                        display: true,\r\n                                    text" +
                    ": \'Hub\',\r\n                                    padding: 3\r\n                      " +
                    "          },\r\n                                scales: {\r\n                       " +
                    "             xAxes: [{\r\n                                        stacked: true, /" +
                    "/ use stacked bar chart\r\n                                        categoryPercent" +
                    "age: 0.4 // width of bar\r\n                                    }],\r\n             " +
                    "                       yAxes: [{\r\n                                        stacke" +
                    "d: true // use stacked bar chart\r\n                                    }]\r\n      " +
                    "                          },\r\n                                legend: {\r\n       " +
                    "                             labels: {\r\n                                        " +
                    "boxWidth: 30,\r\n                                        padding: 20\r\n            " +
                    "                        },\r\n                                    display: true\r\n " +
                    "                               },\r\n                                tooltips: {\r\n" +
                    "                                    mode: \'label\' // data colum for tooltip\r\n   " +
                    "                             },\r\n                                responsive: tru" +
                    "e\r\n                            }\r\n                        });\r\n                 " +
                    "   </script>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    " +
                    "</main>\r\n\r\n    <footer class=\"text-muted\" style=\"padding-top: 3rem;padding-botto" +
                    "m: 3rem;\">\r\n        <div class=container>\r\n            <a href=\"#\" class=\"btn bt" +
                    "n-outline-info float-right\" role=\"button\">\r\n                <i class=\"fa fa-angl" +
                    "e-up\"></i>\r\n            </a>\r\n            <p class=\"text-center\">\r\n             " +
                    "   <a class=\"text-dark\" href=\"https://github.com/cysharp/MagicOnion/\">Visit the " +
                    "GitHub</a>\r\n            /\r\n            © 2020 Copyright:\r\n                <a cla" +
                    "ss=\"text-dark\" href=\"https://cysharp.co.jp/\">Cysharp, Inc.</a>\r\n            </p>" +
                    "\r\n        </div>\r\n    </footer>\r\n\r\n    <script src=\"https://stackpath.bootstrapc" +
                    "dn.com/bootstrap/4.5.0/js/bootstrap.min.js\"\r\n        integrity=\"sha384-OgVRvuATP" +
                    "1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI\"\r\n        crossorigin=\"a" +
                    "nonymous\"></script>\r\n    <!-- MDB -->\r\n    <script type=\"text/javascript\" src=\"h" +
                    "ttps://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/3.0.0/mdb.min.js\"></script>\r\n</" +
                    "body>\r\n\r\n</html>");
            return this.GenerationEnvironment.ToString();
        }
    }
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class BenchmarkReportPageTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
