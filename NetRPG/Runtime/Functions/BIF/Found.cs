using System;
using System.Collections.Generic;
using System.Text;
using NetRPG.Runtime.Typing;
using NetRPG.Runtime.Typing.Files;

namespace NetRPG.Runtime.Functions.Operation
{
    class Found : Function
    {
        public override object Execute(object[] Parameters)
        {

            if (Parameters[0] is JSONTable)
            {
                JSONTable table = Parameters[0] as JSONTable;
                return (!table.isEOF() ? "1" : "0");
            }
            else
            {
                Error.ThrowRuntimeError("%FOUND", "Table is required.");
            }
            return null;
        }
    }
}
