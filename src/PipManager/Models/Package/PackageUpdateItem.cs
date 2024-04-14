﻿using PipManager.Languages;
using PipManager.Models.Pages;

namespace PipManager.Models.Package;

public class PackageUpdateItem(LibraryListItem libraryListItem, string newVersion)
{
    public string PackageName { get; set; } = libraryListItem.PackageName;
    public string PackageVersion { get; set; } = string.Format(Lang.Library_CheckUpdate_Current, libraryListItem.PackageVersion);
    public string NewVersion { get; set; } = string.Format(Lang.Library_CheckUpdate_Latest, newVersion);
}
