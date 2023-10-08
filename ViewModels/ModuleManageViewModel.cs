﻿using System;
using System.Windows.Input;
using Chief.Models;
using Index = Chief.Views.Pages.Index;

namespace Chief.ViewModels;

public class ModuleManageViewModel : ViewModelBase
{
    private readonly ModuleSource _source;
    public ModuleManageViewModel() => _source = ModuleSource.Woolang;
    public ModuleManageViewModel(ModuleSource source) => _source = source;

    public static ICommand GotoIndexCommand => ReactiveUI.ReactiveCommand.Create(() =>
    {
        MainWindowViewModel.Instance!.CurrentContent = new Index();
    });

    public string SourceName =>
        _source switch
        {
            ModuleSource.Woolang => "Woolang",
            ModuleSource.Baozi => "Baozi",
            ModuleSource.JoyEngine => "JoyEngine ECS",
            _ => throw new ArgumentOutOfRangeException()
        };
}