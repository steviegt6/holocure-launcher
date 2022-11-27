using System;
using HoloCure.Launcher.Base;
using osu.Framework.Testing;

namespace HoloCure.Launcher.Game.Tests.Visual;

public class LauncherTestScene : TestScene
{
    protected override ITestSceneTestRunner CreateRunner() => new LauncherTestSceneTestRunner();

    private class LauncherTestSceneTestRunner : LauncherBase, ITestSceneTestRunner
    {
        protected override IBuildInfo BuildInfo { get; } = new TestSceneBuildInfo();

        private TestSceneTestRunner.TestRunner runner = null!;

        protected override void LoadAsyncComplete()
        {
            base.LoadAsyncComplete();
            Add(runner = new TestSceneTestRunner.TestRunner());
        }

        public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);

        protected override void InitializeFonts()
        {
        }

        private class TestSceneBuildInfo : IBuildInfo
        {
            public Version AssemblyVersion => typeof(LauncherTestScene).Assembly.GetName()?.Version ?? new Version();

            public bool IsDeployedBuild => false;

            public string ReleaseChannel => "test-scene";
        }
    }
}
