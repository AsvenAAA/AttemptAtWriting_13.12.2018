using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttemptAtWriting_13._12._2018
{
    class GetClasses
    {
        GetStringer getstr;
        CommandLine cmd;
        Calculator calc;
        
        public GetClasses() { }
        public GetClasses(string expression)
        {
            Initialaized();
            getstr.InputExpression = expression;
        }

        private void Initialaized()
        {
            getstr = new GetStringer();
        }

        public void Show()
        {
            getstr.DivisionSt();
        }
    }
}