﻿using PipManager.Models.AppConfigModels;
using PipManager.Models.Package;
using PipManager.Services.Environment.Response;
using System.Diagnostics;

namespace PipManager.Services.Environment;

public interface IEnvironmentService
{
    public bool CheckEnvironmentExists(EnvironmentItem environmentItem);

    public ActionResponse CheckEnvironmentAvailable(EnvironmentItem environmentItem);

    public ActionResponse PurgeEnvironmentCache(EnvironmentItem environmentItem);

    public Task<List<PackageItem>?> GetLibraries();
    public void RefreshPythonEngine();

    public Task<GetVersionsResponse> GetVersions(string packageName, CancellationToken cancellationToken, bool detectNonRelease = true);
    public bool TryKillProcess();
    public ParseRequirementsResponse ParseRequirements(IEnumerable<string> requirements);

    public ActionResponse Install(string packageName, DataReceivedEventHandler consoleOutputCallback, string[]? extraParameters = null);

    public ActionResponse InstallByRequirements(string requirementsFilePath, DataReceivedEventHandler consoleOutputCallback);

    public ActionResponse Download(string packageName, string downloadPath, DataReceivedEventHandler consoleOutputCallback, string[]? extraParameters = null);

    public ActionResponse Update(string packageName, DataReceivedEventHandler consoleOutputCallback);

    public ActionResponse Uninstall(string packageName, DataReceivedEventHandler consoleOutputCallback);
}