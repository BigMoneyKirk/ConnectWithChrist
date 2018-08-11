using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithChrist.DAL.Enums
{
    public enum UserType
    {
        [Description("System Admin")]
        SYSTEM_ADMIN,
        [Description("User")]
        USER
    }
}
