﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace DiseasePredictionApp
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DiseasePredictorAppEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DiseasePredictorAppEntities object using the connection string found in the 'DiseasePredictorAppEntities' section of the application configuration file.
        /// </summary>
        public DiseasePredictorAppEntities() : base("name=DiseasePredictorAppEntities", "DiseasePredictorAppEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DiseasePredictorAppEntities object.
        /// </summary>
        public DiseasePredictorAppEntities(string connectionString) : base(connectionString, "DiseasePredictorAppEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DiseasePredictorAppEntities object.
        /// </summary>
        public DiseasePredictorAppEntities(EntityConnection connection) : base(connection, "DiseasePredictorAppEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Disease> Diseases
        {
            get
            {
                if ((_Diseases == null))
                {
                    _Diseases = base.CreateObjectSet<Disease>("Diseases");
                }
                return _Diseases;
            }
        }
        private ObjectSet<Disease> _Diseases;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Doctor> Doctors
        {
            get
            {
                if ((_Doctors == null))
                {
                    _Doctors = base.CreateObjectSet<Doctor>("Doctors");
                }
                return _Doctors;
            }
        }
        private ObjectSet<Doctor> _Doctors;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Visitor> Visitors
        {
            get
            {
                if ((_Visitors == null))
                {
                    _Visitors = base.CreateObjectSet<Visitor>("Visitors");
                }
                return _Visitors;
            }
        }
        private ObjectSet<Visitor> _Visitors;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Diseases EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDiseases(Disease disease)
        {
            base.AddObject("Diseases", disease);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Doctors EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDoctors(Doctor doctor)
        {
            base.AddObject("Doctors", doctor);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Visitors EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToVisitors(Visitor visitor)
        {
            base.AddObject("Visitors", visitor);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DiseasePredictorAppModel", Name="Disease")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Disease : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Disease object.
        /// </summary>
        /// <param name="srId">Initial value of the SrId property.</param>
        /// <param name="disease1">Initial value of the Disease1 property.</param>
        /// <param name="symptom1">Initial value of the Symptom1 property.</param>
        /// <param name="symptom2">Initial value of the Symptom2 property.</param>
        /// <param name="symptom3">Initial value of the Symptom3 property.</param>
        /// <param name="symptom4">Initial value of the Symptom4 property.</param>
        public static Disease CreateDisease(global::System.Int32 srId, global::System.String disease1, global::System.String symptom1, global::System.String symptom2, global::System.String symptom3, global::System.String symptom4)
        {
            Disease disease = new Disease();
            disease.SrId = srId;
            disease.Disease1 = disease1;
            disease.Symptom1 = symptom1;
            disease.Symptom2 = symptom2;
            disease.Symptom3 = symptom3;
            disease.Symptom4 = symptom4;
            return disease;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SrId
        {
            get
            {
                return _SrId;
            }
            set
            {
                if (_SrId != value)
                {
                    OnSrIdChanging(value);
                    ReportPropertyChanging("SrId");
                    _SrId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SrId");
                    OnSrIdChanged();
                }
            }
        }
        private global::System.Int32 _SrId;
        partial void OnSrIdChanging(global::System.Int32 value);
        partial void OnSrIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Disease1
        {
            get
            {
                return _Disease1;
            }
            set
            {
                OnDisease1Changing(value);
                ReportPropertyChanging("Disease1");
                _Disease1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Disease1");
                OnDisease1Changed();
            }
        }
        private global::System.String _Disease1;
        partial void OnDisease1Changing(global::System.String value);
        partial void OnDisease1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Symptom1
        {
            get
            {
                return _Symptom1;
            }
            set
            {
                OnSymptom1Changing(value);
                ReportPropertyChanging("Symptom1");
                _Symptom1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Symptom1");
                OnSymptom1Changed();
            }
        }
        private global::System.String _Symptom1;
        partial void OnSymptom1Changing(global::System.String value);
        partial void OnSymptom1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Symptom2
        {
            get
            {
                return _Symptom2;
            }
            set
            {
                OnSymptom2Changing(value);
                ReportPropertyChanging("Symptom2");
                _Symptom2 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Symptom2");
                OnSymptom2Changed();
            }
        }
        private global::System.String _Symptom2;
        partial void OnSymptom2Changing(global::System.String value);
        partial void OnSymptom2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Symptom3
        {
            get
            {
                return _Symptom3;
            }
            set
            {
                OnSymptom3Changing(value);
                ReportPropertyChanging("Symptom3");
                _Symptom3 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Symptom3");
                OnSymptom3Changed();
            }
        }
        private global::System.String _Symptom3;
        partial void OnSymptom3Changing(global::System.String value);
        partial void OnSymptom3Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Symptom4
        {
            get
            {
                return _Symptom4;
            }
            set
            {
                OnSymptom4Changing(value);
                ReportPropertyChanging("Symptom4");
                _Symptom4 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Symptom4");
                OnSymptom4Changed();
            }
        }
        private global::System.String _Symptom4;
        partial void OnSymptom4Changing(global::System.String value);
        partial void OnSymptom4Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Symptom5
        {
            get
            {
                return _Symptom5;
            }
            set
            {
                OnSymptom5Changing(value);
                ReportPropertyChanging("Symptom5");
                _Symptom5 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Symptom5");
                OnSymptom5Changed();
            }
        }
        private global::System.String _Symptom5;
        partial void OnSymptom5Changing(global::System.String value);
        partial void OnSymptom5Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Symptom6
        {
            get
            {
                return _Symptom6;
            }
            set
            {
                OnSymptom6Changing(value);
                ReportPropertyChanging("Symptom6");
                _Symptom6 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Symptom6");
                OnSymptom6Changed();
            }
        }
        private global::System.String _Symptom6;
        partial void OnSymptom6Changing(global::System.String value);
        partial void OnSymptom6Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Symptom7
        {
            get
            {
                return _Symptom7;
            }
            set
            {
                OnSymptom7Changing(value);
                ReportPropertyChanging("Symptom7");
                _Symptom7 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Symptom7");
                OnSymptom7Changed();
            }
        }
        private global::System.String _Symptom7;
        partial void OnSymptom7Changing(global::System.String value);
        partial void OnSymptom7Changed();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DiseasePredictorAppModel", Name="Doctor")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Doctor : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Doctor object.
        /// </summary>
        /// <param name="srId">Initial value of the SrId property.</param>
        /// <param name="dName">Initial value of the DName property.</param>
        /// <param name="dPhone">Initial value of the DPhone property.</param>
        /// <param name="dAddress">Initial value of the DAddress property.</param>
        public static Doctor CreateDoctor(global::System.Int32 srId, global::System.String dName, global::System.Decimal dPhone, global::System.String dAddress)
        {
            Doctor doctor = new Doctor();
            doctor.SrId = srId;
            doctor.DName = dName;
            doctor.DPhone = dPhone;
            doctor.DAddress = dAddress;
            return doctor;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SrId
        {
            get
            {
                return _SrId;
            }
            set
            {
                if (_SrId != value)
                {
                    OnSrIdChanging(value);
                    ReportPropertyChanging("SrId");
                    _SrId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SrId");
                    OnSrIdChanged();
                }
            }
        }
        private global::System.Int32 _SrId;
        partial void OnSrIdChanging(global::System.Int32 value);
        partial void OnSrIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DName
        {
            get
            {
                return _DName;
            }
            set
            {
                OnDNameChanging(value);
                ReportPropertyChanging("DName");
                _DName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DName");
                OnDNameChanged();
            }
        }
        private global::System.String _DName;
        partial void OnDNameChanging(global::System.String value);
        partial void OnDNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal DPhone
        {
            get
            {
                return _DPhone;
            }
            set
            {
                OnDPhoneChanging(value);
                ReportPropertyChanging("DPhone");
                _DPhone = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DPhone");
                OnDPhoneChanged();
            }
        }
        private global::System.Decimal _DPhone;
        partial void OnDPhoneChanging(global::System.Decimal value);
        partial void OnDPhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DAddress
        {
            get
            {
                return _DAddress;
            }
            set
            {
                OnDAddressChanging(value);
                ReportPropertyChanging("DAddress");
                _DAddress = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DAddress");
                OnDAddressChanged();
            }
        }
        private global::System.String _DAddress;
        partial void OnDAddressChanging(global::System.String value);
        partial void OnDAddressChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DiseasePredictorAppModel", Name="Visitor")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Visitor : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Visitor object.
        /// </summary>
        /// <param name="srId">Initial value of the SrId property.</param>
        /// <param name="vName">Initial value of the VName property.</param>
        /// <param name="vEmail">Initial value of the VEmail property.</param>
        /// <param name="vMessage">Initial value of the VMessage property.</param>
        public static Visitor CreateVisitor(global::System.Int32 srId, global::System.String vName, global::System.String vEmail, global::System.String vMessage)
        {
            Visitor visitor = new Visitor();
            visitor.SrId = srId;
            visitor.VName = vName;
            visitor.VEmail = vEmail;
            visitor.VMessage = vMessage;
            return visitor;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SrId
        {
            get
            {
                return _SrId;
            }
            set
            {
                if (_SrId != value)
                {
                    OnSrIdChanging(value);
                    ReportPropertyChanging("SrId");
                    _SrId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SrId");
                    OnSrIdChanged();
                }
            }
        }
        private global::System.Int32 _SrId;
        partial void OnSrIdChanging(global::System.Int32 value);
        partial void OnSrIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String VName
        {
            get
            {
                return _VName;
            }
            set
            {
                OnVNameChanging(value);
                ReportPropertyChanging("VName");
                _VName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("VName");
                OnVNameChanged();
            }
        }
        private global::System.String _VName;
        partial void OnVNameChanging(global::System.String value);
        partial void OnVNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String VEmail
        {
            get
            {
                return _VEmail;
            }
            set
            {
                OnVEmailChanging(value);
                ReportPropertyChanging("VEmail");
                _VEmail = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("VEmail");
                OnVEmailChanged();
            }
        }
        private global::System.String _VEmail;
        partial void OnVEmailChanging(global::System.String value);
        partial void OnVEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String VMessage
        {
            get
            {
                return _VMessage;
            }
            set
            {
                OnVMessageChanging(value);
                ReportPropertyChanging("VMessage");
                _VMessage = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("VMessage");
                OnVMessageChanged();
            }
        }
        private global::System.String _VMessage;
        partial void OnVMessageChanging(global::System.String value);
        partial void OnVMessageChanged();

        #endregion

    
    }

    #endregion

    
}