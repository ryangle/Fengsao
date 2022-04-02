﻿using Fengsao.AduSkinModule.Enum;
using AduSkin.Utility.Extend;

namespace Fengsao.AduSkinModule.Models;

public class ControlModel
{
    public ControlModel(string title, Type content, DemoType type = DemoType.Demo, ControlState state = ControlState.Nor, string xaml = "", string code = "", string tags = "")
    {
        Title = title;
        TitlePinyin = StringExtend.GetPinyin(title);
        Content = content;
        Type = type;
        Tags = tags;
        XAML = xaml;
        Code = code;
        State = state;
    }

    public ControlModel()
    {
        Tags = string.Empty;
    }

    public DemoType Type { get; set; }

    public int Id { get; private set; }

    public string Title { get; set; }

    public string TitlePinyin { get; set; }

    public Type Content { get; set; }

    public string XAML { get; set; }

    public string Code { get; set; }

    public string Tags { get; set; }

    public ControlState State { get; set; }
}
