﻿using CERA.AuthenticationService;
using CERA.CloudService;
using CERA.DataOperation;
using CERA.Entities;
using CERA.Entities.Models;
using CERA.Entities.ViewModels;
using CERA.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace CERA.Azure.CloudService
{
    public class CeraAzureApiService : ICeraAzureApiService
    {
        public CeraAzureApiService()
        {
        }
        public List<CeraPlatformConfigViewModel> _platformConfigs { get; set; }
        ICeraAuthenticator authenticator;
         ICeraDataOperation _dataOps;
        ICeraCloudApiService _ceraCloudApiService;
      public List<CeraSubscription> _subscription { get; set; }
        public ICeraLogger Logger { get; set; }
        

        public CeraAzureApiService(ICeraLogger logger,ICeraDataOperation dataOps,ICeraCloudApiService ceraCloudApiService)
        {
            Logger = logger;
            _dataOps = dataOps;
            _ceraCloudApiService = ceraCloudApiService;
           
        }
        //void DbSubscriptions()
        //{
        //    _subscription = _ceraCloudApiService.GetSubscriptionList();
        //}
        
        public List<CeraResources> GetCloudResourceList(RequestInfoViewModel requestInfo)
        {
            try
            {
                Initialize();
                var authClient = authenticator.GetAuthenticatedClientUsingAzureCredential();
                Logger.LogInfo("Auth Client Initialized");
                
                var subscriptions1 = _ceraCloudApiService.GetSubscriptionList();
                var subscriptions= _dataOps.GetSubscriptions();

              // var subscriptions = GetCloudSubscriptionList(requestInfo);
              //  DbSubscriptions();
                List<CeraResources> ceraResources = new List<CeraResources>();
                foreach (var sub in subscriptions)
                {
                    var azureResources = authClient.WithSubscription(sub.SubscriptionId).GenericResources.ListAsync().Result;
                    
                    Logger.LogInfo("Got Resources List from a subscription in Azure Cloud Provider");
                    if (azureResources != null)
                    {
                        Logger.LogInfo("Parsing Resources List To CERA Resources");
                       
                        foreach (var resource in azureResources)
                        {
                            ceraResources.Add(new CeraResources
                            {
                                Name = resource.Name,
                                RegionName = resource.RegionName,
                                ResourceGroupName = resource.ResourceGroupName,
                                ResourceType = resource.ResourceType
                            });
                        }
                    }                
                    Logger.LogInfo("Parsing Completed Resources List To CERA Resources");

                    return ceraResources;
                }
                Logger.LogInfo("No Resources List found");
                return null;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                return null;
            }
           
        }
        public object GetCloudMonthlyBillingList()
        {
            return new object();
        }


        public object GetCloudSqlDbList()
        {
            return new object();
        }

        public object GetCloudSqlServerList()
        {
            return new object();
        }
        public void Initialize(string tenantId, string clientID, string clientSecret,string authority)
        {
            authenticator = new CeraAzureAuthenticator(Logger);
            authenticator.Initialize(tenantId, clientID, clientSecret,authority);
        }
        public void Initialize()
        {
            string clientId = azureauth.Default.ClientId;
            string tenantId = azureauth.Default.tenantId;
            string clientSecret = azureauth.Default.Clientsecert;
            string authority = azureauth.Default.authority;
            authenticator = new CeraAzureAuthenticator(Logger);
            authenticator.Initialize(tenantId, clientId, clientSecret,authority);
        }

        public List<CeraSubscription> GetCloudSubscriptionList(RequestInfoViewModel requestInfo)
        {
            try
            {
                Initialize();
                var authClient = authenticator.GetAuthenticatedClientUsingAzureCredential();
                Logger.LogInfo("Auth Client Initialized");
                var azureSubscriptions = authClient.Subscriptions.ListAsync().Result;
                Logger.LogInfo("Got Subscription List from Azure Cloud Provider");
                if (azureSubscriptions != null)
                {
                    Logger.LogInfo("Parsing Subscription List To CERA Subscription");
                    List<CeraSubscription> subscriptions = new List<CeraSubscription>();
                    foreach (var sub in azureSubscriptions)
                    {
                        subscriptions.Add(new CeraSubscription
                        {
                            SubscriptionId = sub.SubscriptionId,
                            DisplayName = sub.DisplayName,
                            TenantID = sub.Inner.TenantId,

                        });
                        
                    }
                    Logger.LogInfo("Parsing Completed Subscription List To CERA Subscription");
                    
                    return subscriptions;
                }
                Logger.LogInfo("No Subscription List found");
                return null;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                return null;
            }
        }

        public object GetCloudServicePlanList()
        {
            return new object();
        }

        public object GetCloudTenantList()
        {
            return new object();
        }

        public List<CeraVM> GetCloudVMList(RequestInfoViewModel requestInfo)
        {
            try
            {
                Initialize();
                var authClient = authenticator.GetAuthenticatedClientUsingAzureCredential();
                Logger.LogInfo("Auth Client Initialized");
                var VM = authClient.WithSubscription("b6700194-6522-4789-b5a1-c222828c1fba").VirtualMachines.ListAsync().Result;
                Logger.LogInfo("Got Virtual Machines List from Azure Cloud Provider");
                if (VM != null)
                {
                    Logger.LogInfo("Parsing Virtual Machines List To CERA Resources");
                    List<CeraVM> ceraVM = new List<CeraVM>();
                    foreach (var virtualMachine in VM)
                    {
                        ceraVM.Add(new CeraVM
                        {

                            VMName = virtualMachine.Name,
                            RegionName = virtualMachine.RegionName,
                            ResourceGroupName = virtualMachine.ResourceGroupName,
                            
                        });
                    }
                    Logger.LogInfo("Parsing Completed Resources List To CERA Resources");

                    return ceraVM;
                }
                Logger.LogInfo("No VM's List found");
                return null;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                return null;
            }
        }

        public object GetCloudWebAppList()
        {
            return new object();
        }
        public List<CeraSubscription> GetSubscriptionList()
        {
            return new List<CeraSubscription>();
        }
        public List<CeraResources> GetResourcesList()
        {
            return new List<CeraResources>();
        }
        public List<CeraVM> GetVMList()
        {
            return new List<CeraVM>();
        }
    }
}
