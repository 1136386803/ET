namespace ET
{
    public class AfterCreateZoneScene_AddComponent: AEvent<EventType.AfterCreateZoneScene>
    {
        protected override async ETTask Run(EventType.AfterCreateZoneScene args)
        {
            Scene zoneScene = args.ZoneScene;
            zoneScene.AddComponent<FUIManagerComponent>();
            zoneScene.AddComponent<FUIPackageManagerComponent>();
            await ETTask.CompletedTask;
        }
    }
}