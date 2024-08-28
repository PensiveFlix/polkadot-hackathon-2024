//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.inclusion.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> CandidateBacked
        /// A candidate was backed. `[candidate, head_data]`
        /// </summary>
        CandidateBacked = 0,
        
        /// <summary>
        /// >> CandidateIncluded
        /// A candidate was included. `[candidate, head_data]`
        /// </summary>
        CandidateIncluded = 1,
        
        /// <summary>
        /// >> CandidateTimedOut
        /// A candidate timed out. `[candidate, head_data]`
        /// </summary>
        CandidateTimedOut = 2,
        
        /// <summary>
        /// >> UpwardMessagesReceived
        /// Some upward messages have been received and will be processed.
        /// </summary>
        UpwardMessagesReceived = 3,
    }
    
    /// <summary>
    /// >> 502 - Variant[polkadot_runtime_parachains.inclusion.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CandidateReceipt, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.HeadData, Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CoreIndex, Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.GroupIndex>, BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CandidateReceipt, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.HeadData, Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CoreIndex, Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.GroupIndex>, BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CandidateReceipt, Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.HeadData, Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CoreIndex>, BaseTuple<Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}