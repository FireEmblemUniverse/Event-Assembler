﻿// Decompiled with JetBrains decompiler
// Type: Nintenlord.Event_Assembler.Core.Code.StringReplacers.IStringReplacer
// Assembly: Core, Version=9.10.4713.28131, Culture=neutral, PublicKeyToken=null
// MVID: 65F61606-8B59-4B2D-B4B2-32AA8025E687
// Assembly location: E:\crazycolorz5\Dropbox\Unified FE Hacking\ToolBox\EA V9.12.1\Core.exe

using Nintenlord.Event_Assembler.Core.Code.Preprocessors;
using Nintenlord.Utility;
using System.Collections.Generic;
using System.Text;

namespace Nintenlord.Event_Assembler.Core.Code.StringReplacers
{
  internal interface IStringReplacer
  {
    IDictionary<string, IDictionary<int, IMacro>> Values { set; }

    IDictionary<string, IMacro> BuiltInValues { set; }

    int MaxIter { set; }

    bool Replace(string textToEdit, out string newString);

    CanCauseError<string> Replace(string textToEdit);

    CanCauseError Replace(StringBuilder textToEdit);
  }
}
