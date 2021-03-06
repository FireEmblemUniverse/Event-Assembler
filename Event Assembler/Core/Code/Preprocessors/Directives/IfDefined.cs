﻿// Decompiled with JetBrains decompiler
// Type: Nintenlord.Event_Assembler.Core.Code.Preprocessors.Directives.IfDefined
// Assembly: Core, Version=9.10.4713.28131, Culture=neutral, PublicKeyToken=null
// MVID: 65F61606-8B59-4B2D-B4B2-32AA8025E687
// Assembly location: E:\crazycolorz5\Dropbox\Unified FE Hacking\ToolBox\EA V9.12.1\Core.exe

using Nintenlord.Utility;

namespace Nintenlord.Event_Assembler.Core.Code.Preprocessors.Directives
{
  internal class IfDefined : IDirective, INamed<string>, IParameterized
  {
    public string Name
    {
      get
      {
        return "ifdef";
      }
    }

    public bool RequireIncluding
    {
      get
      {
        return false;
      }
    }

    public int MinAmountOfParameters
    {
      get
      {
        return 1;
      }
    }

    public int MaxAmountOfParameters
    {
      get
      {
        return -1;
      }
    }

    public CanCauseError Apply(string[] parameters, IDirectivePreprocessor host)
    {
      bool flag = false;
      foreach (string parameter in parameters)
      {
        if (host.DefCol.ContainsName(parameter) || host.IsPredefined(parameter))
        {
          flag = true;
          break;
        }
      }
      host.Include.Push(flag);
      return CanCauseError.NoError;
    }
  }
}
