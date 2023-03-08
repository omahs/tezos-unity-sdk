using TezosAPI;
using UnityEngine;

namespace Temp.TezosSDKForUnityExamples
{
    /// <summary>
    /// Replace with comments...
    /// </summary>
    public class Example02_AuthenticationWithoutQR : MonoBehaviour
    {
        //  Events ----------------------------------------
        private const string NetworkName = "ghostnet";//"jakartanet";
        private const string NetworkRPC = "https://rpc.ghostnet.teztnets.xyz";//"https://jakartanet.tezos.marigold.dev";
        private const string IndexerNode = "https://api.ghostnet.tzkt.io/v1/operations/{0}/status"; //"https://api.mainnet.tzkt.io/v1/operations/{transactionHash}/status";
        
        ///
        private const int softCurrencyID = 0;
        private const string ContractAddress = "KT1WguzxyLmuKbJhz3jNuoRzzaUCncfp6PFE";//"KT1DMWAeaP6wxKWPFDLGDkB7xUg563852AjD";

        //  Properties ------------------------------------

        //  Fields ----------------------------------------

        //  Unity Methods --------------------------------
        protected void Start()
        {
            var _tezos = new Tezos(NetworkName, NetworkRPC, IndexerNode);
            _tezos.MessageReceiver.AccountConnected += OnAccountConnected;
            _tezos.MessageReceiver.AccountConnectionFailed += OnAccountConnectionFailed;
            _tezos.MessageReceiver.AccountDisconnected += OnAccountDisconnected;
            _tezos.ConnectWallet();
        }


        
        //  Event Handlers --------------------------------
        private void OnAccountConnectionFailed(string obj)
        {
            Debug.Log($"AccountDisconnected: {obj}");
        }

        
        private void OnAccountDisconnected(string obj)
        {
            Debug.Log($"AccountDisconnected: {obj}");
        }
        
        
        private void OnAccountConnected(string obj)
        {
            Debug.Log($"AccountDisconnected: {obj}");
        }
    }
}