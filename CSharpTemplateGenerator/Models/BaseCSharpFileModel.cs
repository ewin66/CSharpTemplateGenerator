﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTemplateGenerator
{
    public abstract class BaseCSharpFileModel
    {
        List<MethodModel> Methods;
        List<VariableModel> Variables;
    }
}
