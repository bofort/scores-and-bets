﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tests.ScoresService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MATCH", Namespace="http://schemas.datacontract.org/2004/07/Common.DataContracts")]
    [System.SerializableAttribute()]
    public partial class MATCH : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DATEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GUEST_GOALField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GUEST_TEAMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HOME_GOALField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HOME_TEAMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_LEAGUEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_ROUNDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string STATUSField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DATE {
            get {
                return this.DATEField;
            }
            set {
                if ((object.ReferenceEquals(this.DATEField, value) != true)) {
                    this.DATEField = value;
                    this.RaisePropertyChanged("DATE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GUEST_GOAL {
            get {
                return this.GUEST_GOALField;
            }
            set {
                if ((this.GUEST_GOALField.Equals(value) != true)) {
                    this.GUEST_GOALField = value;
                    this.RaisePropertyChanged("GUEST_GOAL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GUEST_TEAM {
            get {
                return this.GUEST_TEAMField;
            }
            set {
                if ((object.ReferenceEquals(this.GUEST_TEAMField, value) != true)) {
                    this.GUEST_TEAMField = value;
                    this.RaisePropertyChanged("GUEST_TEAM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HOME_GOAL {
            get {
                return this.HOME_GOALField;
            }
            set {
                if ((this.HOME_GOALField.Equals(value) != true)) {
                    this.HOME_GOALField = value;
                    this.RaisePropertyChanged("HOME_GOAL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HOME_TEAM {
            get {
                return this.HOME_TEAMField;
            }
            set {
                if ((object.ReferenceEquals(this.HOME_TEAMField, value) != true)) {
                    this.HOME_TEAMField = value;
                    this.RaisePropertyChanged("HOME_TEAM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_LEAGUE {
            get {
                return this.ID_LEAGUEField;
            }
            set {
                if ((this.ID_LEAGUEField.Equals(value) != true)) {
                    this.ID_LEAGUEField = value;
                    this.RaisePropertyChanged("ID_LEAGUE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_ROUND {
            get {
                return this.ID_ROUNDField;
            }
            set {
                if ((this.ID_ROUNDField.Equals(value) != true)) {
                    this.ID_ROUNDField = value;
                    this.RaisePropertyChanged("ID_ROUND");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string STATUS {
            get {
                return this.STATUSField;
            }
            set {
                if ((object.ReferenceEquals(this.STATUSField, value) != true)) {
                    this.STATUSField = value;
                    this.RaisePropertyChanged("STATUS");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BET", Namespace="http://schemas.datacontract.org/2004/07/Common.DataContracts")]
    [System.SerializableAttribute()]
    public partial class BET : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_USERField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BID {
            get {
                return this.BIDField;
            }
            set {
                if ((this.BIDField.Equals(value) != true)) {
                    this.BIDField = value;
                    this.RaisePropertyChanged("BID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_USER {
            get {
                return this.ID_USERField;
            }
            set {
                if ((this.ID_USERField.Equals(value) != true)) {
                    this.ID_USERField = value;
                    this.RaisePropertyChanged("ID_USER");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TEAM", Namespace="http://schemas.datacontract.org/2004/07/Common.DataContracts")]
    [System.SerializableAttribute()]
    public partial class TEAM : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DRAWField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GOAL_CONCEDEDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GOAL_SCOREDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_LEAGUEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LOSEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NAMEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int POINTSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WINField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DRAW {
            get {
                return this.DRAWField;
            }
            set {
                if ((this.DRAWField.Equals(value) != true)) {
                    this.DRAWField = value;
                    this.RaisePropertyChanged("DRAW");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GOAL_CONCEDED {
            get {
                return this.GOAL_CONCEDEDField;
            }
            set {
                if ((this.GOAL_CONCEDEDField.Equals(value) != true)) {
                    this.GOAL_CONCEDEDField = value;
                    this.RaisePropertyChanged("GOAL_CONCEDED");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GOAL_SCORED {
            get {
                return this.GOAL_SCOREDField;
            }
            set {
                if ((this.GOAL_SCOREDField.Equals(value) != true)) {
                    this.GOAL_SCOREDField = value;
                    this.RaisePropertyChanged("GOAL_SCORED");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_LEAGUE {
            get {
                return this.ID_LEAGUEField;
            }
            set {
                if ((this.ID_LEAGUEField.Equals(value) != true)) {
                    this.ID_LEAGUEField = value;
                    this.RaisePropertyChanged("ID_LEAGUE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LOSE {
            get {
                return this.LOSEField;
            }
            set {
                if ((this.LOSEField.Equals(value) != true)) {
                    this.LOSEField = value;
                    this.RaisePropertyChanged("LOSE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NAME {
            get {
                return this.NAMEField;
            }
            set {
                if ((object.ReferenceEquals(this.NAMEField, value) != true)) {
                    this.NAMEField = value;
                    this.RaisePropertyChanged("NAME");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int POINTS {
            get {
                return this.POINTSField;
            }
            set {
                if ((this.POINTSField.Equals(value) != true)) {
                    this.POINTSField = value;
                    this.RaisePropertyChanged("POINTS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int WIN {
            get {
                return this.WINField;
            }
            set {
                if ((this.WINField.Equals(value) != true)) {
                    this.WINField = value;
                    this.RaisePropertyChanged("WIN");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BETS_MATCHES", Namespace="http://schemas.datacontract.org/2004/07/Common.DataContracts")]
    [System.SerializableAttribute()]
    public partial class BETS_MATCHES : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_BETField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_MATCHField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TYPEField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_BET {
            get {
                return this.ID_BETField;
            }
            set {
                if ((this.ID_BETField.Equals(value) != true)) {
                    this.ID_BETField = value;
                    this.RaisePropertyChanged("ID_BET");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_MATCH {
            get {
                return this.ID_MATCHField;
            }
            set {
                if ((this.ID_MATCHField.Equals(value) != true)) {
                    this.ID_MATCHField = value;
                    this.RaisePropertyChanged("ID_MATCH");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TYPE {
            get {
                return this.TYPEField;
            }
            set {
                if ((this.TYPEField.Equals(value) != true)) {
                    this.TYPEField = value;
                    this.RaisePropertyChanged("TYPE");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LEAGUE", Namespace="http://schemas.datacontract.org/2004/07/Common.DataContracts")]
    [System.SerializableAttribute()]
    public partial class LEAGUE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LINKField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NAMEField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LINK {
            get {
                return this.LINKField;
            }
            set {
                if ((object.ReferenceEquals(this.LINKField, value) != true)) {
                    this.LINKField = value;
                    this.RaisePropertyChanged("LINK");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NAME {
            get {
                return this.NAMEField;
            }
            set {
                if ((object.ReferenceEquals(this.NAMEField, value) != true)) {
                    this.NAMEField = value;
                    this.RaisePropertyChanged("NAME");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ScoresService.IScoresService")]
    public interface IScoresService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetAllMatches", ReplyAction="http://tempuri.org/IScoresService/GetAllMatchesResponse")]
        Tests.ScoresService.MATCH[] GetAllMatches();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetAllMatches", ReplyAction="http://tempuri.org/IScoresService/GetAllMatchesResponse")]
        System.Threading.Tasks.Task<Tests.ScoresService.MATCH[]> GetAllMatchesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetLiveMatches", ReplyAction="http://tempuri.org/IScoresService/GetLiveMatchesResponse")]
        Tests.ScoresService.MATCH[] GetLiveMatches();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetLiveMatches", ReplyAction="http://tempuri.org/IScoresService/GetLiveMatchesResponse")]
        System.Threading.Tasks.Task<Tests.ScoresService.MATCH[]> GetLiveMatchesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetAllBets", ReplyAction="http://tempuri.org/IScoresService/GetAllBetsResponse")]
        Tests.ScoresService.BET[] GetAllBets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetAllBets", ReplyAction="http://tempuri.org/IScoresService/GetAllBetsResponse")]
        System.Threading.Tasks.Task<Tests.ScoresService.BET[]> GetAllBetsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetAllTeams", ReplyAction="http://tempuri.org/IScoresService/GetAllTeamsResponse")]
        Tests.ScoresService.TEAM[] GetAllTeams();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetAllTeams", ReplyAction="http://tempuri.org/IScoresService/GetAllTeamsResponse")]
        System.Threading.Tasks.Task<Tests.ScoresService.TEAM[]> GetAllTeamsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetUserMatches", ReplyAction="http://tempuri.org/IScoresService/GetUserMatchesResponse")]
        Tests.ScoresService.MATCH[] GetUserMatches();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetUserMatches", ReplyAction="http://tempuri.org/IScoresService/GetUserMatchesResponse")]
        System.Threading.Tasks.Task<Tests.ScoresService.MATCH[]> GetUserMatchesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetMatchesForBet", ReplyAction="http://tempuri.org/IScoresService/GetMatchesForBetResponse")]
        Tests.ScoresService.BETS_MATCHES[] GetMatchesForBet();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetMatchesForBet", ReplyAction="http://tempuri.org/IScoresService/GetMatchesForBetResponse")]
        System.Threading.Tasks.Task<Tests.ScoresService.BETS_MATCHES[]> GetMatchesForBetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetAllLeagues", ReplyAction="http://tempuri.org/IScoresService/GetAllLeaguesResponse")]
        Tests.ScoresService.LEAGUE[] GetAllLeagues();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetAllLeagues", ReplyAction="http://tempuri.org/IScoresService/GetAllLeaguesResponse")]
        System.Threading.Tasks.Task<Tests.ScoresService.LEAGUE[]> GetAllLeaguesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetBet", ReplyAction="http://tempuri.org/IScoresService/GetBetResponse")]
        Tests.ScoresService.BET GetBet(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetBet", ReplyAction="http://tempuri.org/IScoresService/GetBetResponse")]
        System.Threading.Tasks.Task<Tests.ScoresService.BET> GetBetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetLeagueTable", ReplyAction="http://tempuri.org/IScoresService/GetLeagueTableResponse")]
        Tests.ScoresService.TEAM[] GetLeagueTable(int idLeague);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/GetLeagueTable", ReplyAction="http://tempuri.org/IScoresService/GetLeagueTableResponse")]
        System.Threading.Tasks.Task<Tests.ScoresService.TEAM[]> GetLeagueTableAsync(int idLeague);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/AddLeague", ReplyAction="http://tempuri.org/IScoresService/AddLeagueResponse")]
        void AddLeague(Tests.ScoresService.LEAGUE league);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/AddLeague", ReplyAction="http://tempuri.org/IScoresService/AddLeagueResponse")]
        System.Threading.Tasks.Task AddLeagueAsync(Tests.ScoresService.LEAGUE league);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/DeleteLeague", ReplyAction="http://tempuri.org/IScoresService/DeleteLeagueResponse")]
        void DeleteLeague(Tests.ScoresService.LEAGUE[] leagueList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/DeleteLeague", ReplyAction="http://tempuri.org/IScoresService/DeleteLeagueResponse")]
        System.Threading.Tasks.Task DeleteLeagueAsync(Tests.ScoresService.LEAGUE[] leagueList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/AddToUserMatches", ReplyAction="http://tempuri.org/IScoresService/AddToUserMatchesResponse")]
        void AddToUserMatches(Tests.ScoresService.MATCH[] matchesList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/AddToUserMatches", ReplyAction="http://tempuri.org/IScoresService/AddToUserMatchesResponse")]
        System.Threading.Tasks.Task AddToUserMatchesAsync(Tests.ScoresService.MATCH[] matchesList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/DeleteFromMyMatches", ReplyAction="http://tempuri.org/IScoresService/DeleteFromMyMatchesResponse")]
        void DeleteFromMyMatches(Tests.ScoresService.MATCH[] matchesList);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScoresService/DeleteFromMyMatches", ReplyAction="http://tempuri.org/IScoresService/DeleteFromMyMatchesResponse")]
        System.Threading.Tasks.Task DeleteFromMyMatchesAsync(Tests.ScoresService.MATCH[] matchesList);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IScoresServiceChannel : Tests.ScoresService.IScoresService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ScoresServiceClient : System.ServiceModel.ClientBase<Tests.ScoresService.IScoresService>, Tests.ScoresService.IScoresService {
        
        public ScoresServiceClient() {
        }
        
        public ScoresServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScoresServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScoresServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScoresServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Tests.ScoresService.MATCH[] GetAllMatches() {
            return base.Channel.GetAllMatches();
        }
        
        public System.Threading.Tasks.Task<Tests.ScoresService.MATCH[]> GetAllMatchesAsync() {
            return base.Channel.GetAllMatchesAsync();
        }
        
        public Tests.ScoresService.MATCH[] GetLiveMatches() {
            return base.Channel.GetLiveMatches();
        }
        
        public System.Threading.Tasks.Task<Tests.ScoresService.MATCH[]> GetLiveMatchesAsync() {
            return base.Channel.GetLiveMatchesAsync();
        }
        
        public Tests.ScoresService.BET[] GetAllBets() {
            return base.Channel.GetAllBets();
        }
        
        public System.Threading.Tasks.Task<Tests.ScoresService.BET[]> GetAllBetsAsync() {
            return base.Channel.GetAllBetsAsync();
        }
        
        public Tests.ScoresService.TEAM[] GetAllTeams() {
            return base.Channel.GetAllTeams();
        }
        
        public System.Threading.Tasks.Task<Tests.ScoresService.TEAM[]> GetAllTeamsAsync() {
            return base.Channel.GetAllTeamsAsync();
        }
        
        public Tests.ScoresService.MATCH[] GetUserMatches() {
            return base.Channel.GetUserMatches();
        }
        
        public System.Threading.Tasks.Task<Tests.ScoresService.MATCH[]> GetUserMatchesAsync() {
            return base.Channel.GetUserMatchesAsync();
        }
        
        public Tests.ScoresService.BETS_MATCHES[] GetMatchesForBet() {
            return base.Channel.GetMatchesForBet();
        }
        
        public System.Threading.Tasks.Task<Tests.ScoresService.BETS_MATCHES[]> GetMatchesForBetAsync() {
            return base.Channel.GetMatchesForBetAsync();
        }
        
        public Tests.ScoresService.LEAGUE[] GetAllLeagues() {
            return base.Channel.GetAllLeagues();
        }
        
        public System.Threading.Tasks.Task<Tests.ScoresService.LEAGUE[]> GetAllLeaguesAsync() {
            return base.Channel.GetAllLeaguesAsync();
        }
        
        public Tests.ScoresService.BET GetBet(int id) {
            return base.Channel.GetBet(id);
        }
        
        public System.Threading.Tasks.Task<Tests.ScoresService.BET> GetBetAsync(int id) {
            return base.Channel.GetBetAsync(id);
        }
        
        public Tests.ScoresService.TEAM[] GetLeagueTable(int idLeague) {
            return base.Channel.GetLeagueTable(idLeague);
        }
        
        public System.Threading.Tasks.Task<Tests.ScoresService.TEAM[]> GetLeagueTableAsync(int idLeague) {
            return base.Channel.GetLeagueTableAsync(idLeague);
        }
        
        public void AddLeague(Tests.ScoresService.LEAGUE league) {
            base.Channel.AddLeague(league);
        }
        
        public System.Threading.Tasks.Task AddLeagueAsync(Tests.ScoresService.LEAGUE league) {
            return base.Channel.AddLeagueAsync(league);
        }
        
        public void DeleteLeague(Tests.ScoresService.LEAGUE[] leagueList) {
            base.Channel.DeleteLeague(leagueList);
        }
        
        public System.Threading.Tasks.Task DeleteLeagueAsync(Tests.ScoresService.LEAGUE[] leagueList) {
            return base.Channel.DeleteLeagueAsync(leagueList);
        }
        
        public void AddToUserMatches(Tests.ScoresService.MATCH[] matchesList) {
            base.Channel.AddToUserMatches(matchesList);
        }
        
        public System.Threading.Tasks.Task AddToUserMatchesAsync(Tests.ScoresService.MATCH[] matchesList) {
            return base.Channel.AddToUserMatchesAsync(matchesList);
        }
        
        public void DeleteFromMyMatches(Tests.ScoresService.MATCH[] matchesList) {
            base.Channel.DeleteFromMyMatches(matchesList);
        }
        
        public System.Threading.Tasks.Task DeleteFromMyMatchesAsync(Tests.ScoresService.MATCH[] matchesList) {
            return base.Channel.DeleteFromMyMatchesAsync(matchesList);
        }
    }
}