using Microsoft.Extensions.Logging;

namespace ServerPrototype.Shared
{
   public class ResourceProductionCalculator
   {
       public static Dictionary<ResourceType, ulong> GetResourceAmountToReceive(
           DateTime lastUpdateUtc,
           Dictionary<ResourceType, ulong> resourcePerNTimeBase,
           Dictionary<ResourceType, double> boostResourcePerResource,
           ILogger logger,
           double timeMultiplayer = 1)
       {
           Dictionary<ResourceType, ulong> result = new Dictionary<ResourceType, ulong>(resourcePerNTimeBase.Count);
   
           var amountOfSecFromLastUpdate = (long)(DateTime.UtcNow - lastUpdateUtc).TotalSeconds * timeMultiplayer;
   
           if (amountOfSecFromLastUpdate < 0)
               logger.LogError($"ResourceProductionCalculator.GetResourceAmountToReceive amountOfSecFromLastUpdate < 0, {amountOfSecFromLastUpdate}");
   
           foreach (var resource in resourcePerNTimeBase)
           {
               double resourceBonusMultiplayer = 0.0D;
               boostResourcePerResource.TryGetValue(resource.Key, out resourceBonusMultiplayer);
               var finalBonusMultiplayer = 1 + resourceBonusMultiplayer;
   
               
               var resourceWithoutBonuses = resource.Value * (ulong)amountOfSecFromLastUpdate;
               var resourceWithBonuses = resourceWithoutBonuses * finalBonusMultiplayer;
   
               
               result.Add(resource.Key, Convert.ToUInt64(resourceWithBonuses));
           }
   
   
           return result;
       }
   }
}
