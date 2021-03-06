﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace ReadTestsAdventureWorks2008.EntityClasses
{
	/// <summary>Class which represents the entity 'Document', mapped on table 'AdventureWorks.Production.Document'.</summary>
	public partial class Document : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_changeNumber;
		private System.Data.Linq.Binary	_documentData;
		private Nullable<System.Int16>	_documentLevel;
		private System.String	_documentNode;
		private System.String	_documentSummary;
		private System.String	_fileExtension;
		private System.String	_fileName;
		private System.Boolean	_folderFlag;
		private System.DateTime	_modifiedDate;
		private System.Int32	_owner;
		private System.String	_revision;
		private System.Guid	_rowguid;
		private System.Byte	_status;
		private System.String	_title;
		private EntityRef <Employee> _employee;
		private EntitySet <ProductDocument> _productDocuments;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnChangeNumberChanging(System.Int32 value);
		partial void OnChangeNumberChanged();
		partial void OnDocumentDataChanging(System.Data.Linq.Binary value);
		partial void OnDocumentDataChanged();
		partial void OnDocumentLevelChanging(Nullable<System.Int16> value);
		partial void OnDocumentLevelChanged();
		partial void OnDocumentNodeChanging(System.String value);
		partial void OnDocumentNodeChanged();
		partial void OnDocumentSummaryChanging(System.String value);
		partial void OnDocumentSummaryChanged();
		partial void OnFileExtensionChanging(System.String value);
		partial void OnFileExtensionChanged();
		partial void OnFileNameChanging(System.String value);
		partial void OnFileNameChanged();
		partial void OnFolderFlagChanging(System.Boolean value);
		partial void OnFolderFlagChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnOwnerChanging(System.Int32 value);
		partial void OnOwnerChanged();
		partial void OnRevisionChanging(System.String value);
		partial void OnRevisionChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		partial void OnStatusChanging(System.Byte value);
		partial void OnStatusChanged();
		partial void OnTitleChanging(System.String value);
		partial void OnTitleChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="Document"/> class.</summary>
		public Document()
		{
			_employee = default(EntityRef<Employee>);
			_productDocuments = new EntitySet<ProductDocument>(new Action<ProductDocument>(this.Attach_ProductDocuments), new Action<ProductDocument>(this.Detach_ProductDocuments) );
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_ProductDocuments(ProductDocument entity)
		{
			this.SendPropertyChanging("ProductDocuments");
			entity.Document = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_ProductDocuments(ProductDocument entity)
		{
			this.SendPropertyChanging("ProductDocuments");
			entity.Document = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the ChangeNumber field. Mapped on target field 'ChangeNumber'. </summary>
		public System.Int32 ChangeNumber
		{
			get	{ return _changeNumber; }
			set
			{
				if((_changeNumber != value))
				{
					OnChangeNumberChanging(value);
					SendPropertyChanging("ChangeNumber");
					_changeNumber = value;
					SendPropertyChanged("ChangeNumber");
					OnChangeNumberChanged();
				}
			}
		}

		/// <summary>Gets or sets the DocumentData field. Mapped on target field 'Document'. </summary>
		public System.Data.Linq.Binary DocumentData
		{
			get	{ return _documentData; }
			set
			{
				if((_documentData != value))
				{
					OnDocumentDataChanging(value);
					SendPropertyChanging("DocumentData");
					_documentData = value;
					SendPropertyChanged("DocumentData");
					OnDocumentDataChanged();
				}
			}
		}

		/// <summary>Gets or sets the DocumentLevel field. Mapped on target field 'DocumentLevel'. </summary>
		public Nullable<System.Int16> DocumentLevel
		{
			get	{ return _documentLevel; }
		}

		/// <summary>Gets or sets the DocumentNode field. Mapped on target field 'DocumentNode'. </summary>
		public System.String DocumentNode
		{
			get	{ return _documentNode; }
			set
			{
				if((_documentNode != value))
				{
					OnDocumentNodeChanging(value);
					SendPropertyChanging("DocumentNode");
					_documentNode = value;
					SendPropertyChanged("DocumentNode");
					OnDocumentNodeChanged();
				}
			}
		}

		/// <summary>Gets or sets the DocumentSummary field. Mapped on target field 'DocumentSummary'. </summary>
		public System.String DocumentSummary
		{
			get	{ return _documentSummary; }
			set
			{
				if((_documentSummary != value))
				{
					OnDocumentSummaryChanging(value);
					SendPropertyChanging("DocumentSummary");
					_documentSummary = value;
					SendPropertyChanged("DocumentSummary");
					OnDocumentSummaryChanged();
				}
			}
		}

		/// <summary>Gets or sets the FileExtension field. Mapped on target field 'FileExtension'. </summary>
		public System.String FileExtension
		{
			get	{ return _fileExtension; }
			set
			{
				if((_fileExtension != value))
				{
					OnFileExtensionChanging(value);
					SendPropertyChanging("FileExtension");
					_fileExtension = value;
					SendPropertyChanged("FileExtension");
					OnFileExtensionChanged();
				}
			}
		}

		/// <summary>Gets or sets the FileName field. Mapped on target field 'FileName'. </summary>
		public System.String FileName
		{
			get	{ return _fileName; }
			set
			{
				if((_fileName != value))
				{
					OnFileNameChanging(value);
					SendPropertyChanging("FileName");
					_fileName = value;
					SendPropertyChanged("FileName");
					OnFileNameChanged();
				}
			}
		}

		/// <summary>Gets or sets the FolderFlag field. Mapped on target field 'FolderFlag'. </summary>
		public System.Boolean FolderFlag
		{
			get	{ return _folderFlag; }
			set
			{
				if((_folderFlag != value))
				{
					OnFolderFlagChanging(value);
					SendPropertyChanging("FolderFlag");
					_folderFlag = value;
					SendPropertyChanged("FolderFlag");
					OnFolderFlagChanged();
				}
			}
		}

		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the Owner field. Mapped on target field 'Owner'. </summary>
		public System.Int32 Owner
		{
			get	{ return _owner; }
			set
			{
				if((_owner != value))
				{
					if(_employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnOwnerChanging(value);
					SendPropertyChanging("Owner");
					_owner = value;
					SendPropertyChanged("Owner");
					OnOwnerChanged();
				}
			}
		}

		/// <summary>Gets or sets the Revision field. Mapped on target field 'Revision'. </summary>
		public System.String Revision
		{
			get	{ return _revision; }
			set
			{
				if((_revision != value))
				{
					OnRevisionChanging(value);
					SendPropertyChanging("Revision");
					_revision = value;
					SendPropertyChanged("Revision");
					OnRevisionChanged();
				}
			}
		}

		/// <summary>Gets or sets the Rowguid field. Mapped on target field 'rowguid'. </summary>
		public System.Guid Rowguid
		{
			get	{ return _rowguid; }
			set
			{
				if((_rowguid != value))
				{
					OnRowguidChanging(value);
					SendPropertyChanging("Rowguid");
					_rowguid = value;
					SendPropertyChanged("Rowguid");
					OnRowguidChanged();
				}
			}
		}

		/// <summary>Gets or sets the Status field. Mapped on target field 'Status'. </summary>
		public System.Byte Status
		{
			get	{ return _status; }
			set
			{
				if((_status != value))
				{
					OnStatusChanging(value);
					SendPropertyChanging("Status");
					_status = value;
					SendPropertyChanged("Status");
					OnStatusChanged();
				}
			}
		}

		/// <summary>Gets or sets the Title field. Mapped on target field 'Title'. </summary>
		public System.String Title
		{
			get	{ return _title; }
			set
			{
				if((_title != value))
				{
					OnTitleChanging(value);
					SendPropertyChanging("Title");
					_title = value;
					SendPropertyChanged("Title");
					OnTitleChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Document.Employee - Employee.Documents (m:1)'</summary>
		public Employee Employee
		{
			get { return _employee.Entity; }
			set
			{
				Employee previousValue = _employee.Entity;
				if((previousValue != value) || (_employee.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Employee");
					if(previousValue != null)
					{
						_employee.Entity = null;
						previousValue.Documents.Remove(this);
					}
					_employee.Entity = value;
					if(value == null)
					{
						_owner = default(System.Int32);
					}
					else
					{
						value.Documents.Add(this);
						_owner = value.BusinessEntityId;
					}
					this.SendPropertyChanged("Employee");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'ProductDocument.Document - Document.ProductDocuments (m:1)'</summary>
		public EntitySet<ProductDocument> ProductDocuments
		{
			get { return this._productDocuments; }
			set { this._productDocuments.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649