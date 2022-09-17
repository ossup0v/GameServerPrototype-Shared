//using Microsoft.Extensions.Logging;

namespace ServerPrototype.Shared
{
   //public class ResourceProfitCalculator
   //{
   //    public static Dictionary<int, ulong> GetResourceAmountToReceive(
   //        DateTime lastUpdateUtc,
   //        Dictionary<int, ulong> resourcePerNTimeBase,
   //        Dictionary<int, decimal> boostResourcePerResource,
   //        ILogger logger,
   //        decimal timeMultiplayer = 1)
   //    {
   //        Dictionary<int, ulong> result = new Dictionary<int, ulong>(resourcePerNTimeBase.Count);
   //
   //        var amountOfSecFromLastUpdate = (long)(DateTime.UtcNow - lastUpdateUtc).TotalSeconds * timeMultiplayer;
   //
   //        if (amountOfSecFromLastUpdate < 0)
   //            logger.LogError($"ResourceProfitCalculator.GetResourceAmountToReceive amountOfSecFromLastUpdate < 0, {amountOfSecFromLastUpdate}");
   //
   //        foreach (var resource in resourcePerNTimeBase)
   //        {
   //            decimal resourceBonusMultiplayer = 0.0M;
   //            boostResourcePerResource.TryGetValue(resource.Key, out resourceBonusMultiplayer);
   //            var finalBonusMultiplayer = 1 + resourceBonusMultiplayer;
   //
   //            
   //            var resourceWithoutBonuses = resource.Value * (ulong)amountOfSecFromLastUpdate;
   //            var resourceWithBonuses = resourceWithoutBonuses * finalBonusMultiplayer;
   //
   //            
   //            result.Add(resource.Key, Convert.ToUInt64(resourceWithBonuses));
   //        }
   //
   //
   //        return result;
   //    }
   //}
}
