using System;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Xml.Serialization;
using SubSonic;

// <auto-generated />

namespace Vietbait.Lablink.Model
{
    /// <summary>
    ///     Strongly-typed collection for the LStandardTest class.
    /// </summary>
    [Serializable]
    public class LStandardTestCollection : ActiveList<LStandardTest, LStandardTestCollection>
    {
        /// <summary>
        ///     Filters an existing collection based on the set criteria. This is an in-memory filter
        ///     Thanks to developingchris for this!
        /// </summary>
        /// <returns>LStandardTestCollection</returns>
        public LStandardTestCollection Filter()
        {
            for (int i = Count - 1; i > -1; i--)
            {
                LStandardTest o = this[i];
                foreach (Where w in wheres)
                {
                    bool remove = false;
                    PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
    }

    /// <summary>
    ///     This is an ActiveRecord class which wraps the L_Standard_Test table.
    /// </summary>
    [Serializable]
    public class LStandardTest : ActiveRecord<LStandardTest>, IActiveRecord
    {
        #region .ctors and Default Settings

        public LStandardTest()
        {
            SetSQLProps();
            InitSetDefaults();
            MarkNew();
        }

        public LStandardTest(bool useDatabaseDefaults)
        {
            SetSQLProps();
            if (useDatabaseDefaults)
                ForceDefaults();
            MarkNew();
        }

        public LStandardTest(object keyID)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByKey(keyID);
        }

        public LStandardTest(string columnName, object columnValue)
        {
            SetSQLProps();
            InitSetDefaults();
            LoadByParam(columnName, columnValue);
        }

        private void InitSetDefaults()
        {
            SetDefaults();
        }

        protected static void SetSQLProps()
        {
            GetTableSchema();
        }

        #endregion

        #region Schema and Query Accessor	

        public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                    SetSQLProps();
                return BaseSchema;
            }
        }

        public static Query CreateQuery()
        {
            return new Query(Schema);
        }

        private static void GetTableSchema()
        {
            if (!IsSchemaInitialized)
            {
                //Schema declaration
                var schema = new TableSchema.Table("L_Standard_Test", TableType.Table, DataService.GetInstance("ORM"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns

                var colvarTestDataId = new TableSchema.TableColumn(schema);
                colvarTestDataId.ColumnName = "TestData_ID";
                colvarTestDataId.DataType = DbType.String;
                colvarTestDataId.MaxLength = 100;
                colvarTestDataId.AutoIncrement = false;
                colvarTestDataId.IsNullable = false;
                colvarTestDataId.IsPrimaryKey = true;
                colvarTestDataId.IsForeignKey = false;
                colvarTestDataId.IsReadOnly = false;
                colvarTestDataId.DefaultSetting = @"";
                colvarTestDataId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarTestDataId);

                var colvarTestTypeId = new TableSchema.TableColumn(schema);
                colvarTestTypeId.ColumnName = "TestType_ID";
                colvarTestTypeId.DataType = DbType.Int32;
                colvarTestTypeId.MaxLength = 0;
                colvarTestTypeId.AutoIncrement = false;
                colvarTestTypeId.IsNullable = false;
                colvarTestTypeId.IsPrimaryKey = false;
                colvarTestTypeId.IsForeignKey = false;
                colvarTestTypeId.IsReadOnly = false;
                colvarTestTypeId.DefaultSetting = @"";
                colvarTestTypeId.ForeignKeyTableName = "";
                schema.Columns.Add(colvarTestTypeId);

                var colvarDataSequence = new TableSchema.TableColumn(schema);
                colvarDataSequence.ColumnName = "Data_Sequence";
                colvarDataSequence.DataType = DbType.Int32;
                colvarDataSequence.MaxLength = 0;
                colvarDataSequence.AutoIncrement = false;
                colvarDataSequence.IsNullable = true;
                colvarDataSequence.IsPrimaryKey = false;
                colvarDataSequence.IsForeignKey = false;
                colvarDataSequence.IsReadOnly = false;
                colvarDataSequence.DefaultSetting = @"";
                colvarDataSequence.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataSequence);

                var colvarDataName = new TableSchema.TableColumn(schema);
                colvarDataName.ColumnName = "Data_Name";
                colvarDataName.DataType = DbType.String;
                colvarDataName.MaxLength = 50;
                colvarDataName.AutoIncrement = false;
                colvarDataName.IsNullable = false;
                colvarDataName.IsPrimaryKey = false;
                colvarDataName.IsForeignKey = false;
                colvarDataName.IsReadOnly = false;
                colvarDataName.DefaultSetting = @"";
                colvarDataName.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataName);

                var colvarMeasureUnit = new TableSchema.TableColumn(schema);
                colvarMeasureUnit.ColumnName = "Measure_Unit";
                colvarMeasureUnit.DataType = DbType.String;
                colvarMeasureUnit.MaxLength = 50;
                colvarMeasureUnit.AutoIncrement = false;
                colvarMeasureUnit.IsNullable = true;
                colvarMeasureUnit.IsPrimaryKey = false;
                colvarMeasureUnit.IsForeignKey = false;
                colvarMeasureUnit.IsReadOnly = false;
                colvarMeasureUnit.DefaultSetting = @"";
                colvarMeasureUnit.ForeignKeyTableName = "";
                schema.Columns.Add(colvarMeasureUnit);

                var colvarDataPoint = new TableSchema.TableColumn(schema);
                colvarDataPoint.ColumnName = "Data_Point";
                colvarDataPoint.DataType = DbType.Int16;
                colvarDataPoint.MaxLength = 0;
                colvarDataPoint.AutoIncrement = false;
                colvarDataPoint.IsNullable = false;
                colvarDataPoint.IsPrimaryKey = false;
                colvarDataPoint.IsForeignKey = false;
                colvarDataPoint.IsReadOnly = false;
                colvarDataPoint.DefaultSetting = @"";
                colvarDataPoint.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataPoint);

                var colvarNormalLevel = new TableSchema.TableColumn(schema);
                colvarNormalLevel.ColumnName = "Normal_Level";
                colvarNormalLevel.DataType = DbType.String;
                colvarNormalLevel.MaxLength = 100;
                colvarNormalLevel.AutoIncrement = false;
                colvarNormalLevel.IsNullable = true;
                colvarNormalLevel.IsPrimaryKey = false;
                colvarNormalLevel.IsForeignKey = false;
                colvarNormalLevel.IsReadOnly = false;
                colvarNormalLevel.DefaultSetting = @"";
                colvarNormalLevel.ForeignKeyTableName = "";
                schema.Columns.Add(colvarNormalLevel);

                var colvarNormalLevelW = new TableSchema.TableColumn(schema);
                colvarNormalLevelW.ColumnName = "Normal_LevelW";
                colvarNormalLevelW.DataType = DbType.String;
                colvarNormalLevelW.MaxLength = 100;
                colvarNormalLevelW.AutoIncrement = false;
                colvarNormalLevelW.IsNullable = true;
                colvarNormalLevelW.IsPrimaryKey = false;
                colvarNormalLevelW.IsForeignKey = false;
                colvarNormalLevelW.IsReadOnly = false;
                colvarNormalLevelW.DefaultSetting = @"";
                colvarNormalLevelW.ForeignKeyTableName = "";
                schema.Columns.Add(colvarNormalLevelW);

                var colvarDataView = new TableSchema.TableColumn(schema);
                colvarDataView.ColumnName = "Data_View";
                colvarDataView.DataType = DbType.Boolean;
                colvarDataView.MaxLength = 0;
                colvarDataView.AutoIncrement = false;
                colvarDataView.IsNullable = true;
                colvarDataView.IsPrimaryKey = false;
                colvarDataView.IsForeignKey = false;
                colvarDataView.IsReadOnly = false;
                colvarDataView.DefaultSetting = @"";
                colvarDataView.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataView);

                var colvarDataPrint = new TableSchema.TableColumn(schema);
                colvarDataPrint.ColumnName = "Data_Print";
                colvarDataPrint.DataType = DbType.Boolean;
                colvarDataPrint.MaxLength = 0;
                colvarDataPrint.AutoIncrement = false;
                colvarDataPrint.IsNullable = true;
                colvarDataPrint.IsPrimaryKey = false;
                colvarDataPrint.IsForeignKey = false;
                colvarDataPrint.IsReadOnly = false;
                colvarDataPrint.DefaultSetting = @"";
                colvarDataPrint.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDataPrint);

                var colvarDescription = new TableSchema.TableColumn(schema);
                colvarDescription.ColumnName = "Description";
                colvarDescription.DataType = DbType.String;
                colvarDescription.MaxLength = 200;
                colvarDescription.AutoIncrement = false;
                colvarDescription.IsNullable = true;
                colvarDescription.IsPrimaryKey = false;
                colvarDescription.IsForeignKey = false;
                colvarDescription.IsReadOnly = false;
                colvarDescription.DefaultSetting = @"";
                colvarDescription.ForeignKeyTableName = "";
                schema.Columns.Add(colvarDescription);

                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["ORM"].AddSchema("L_Standard_Test", schema);
            }
        }

        #endregion

        #region Props

        [XmlAttribute("TestDataId")]
        [Bindable(true)]
        public string TestDataId
        {
            get { return GetColumnValue<string>(Columns.TestDataId); }
            set { SetColumnValue(Columns.TestDataId, value); }
        }

        [XmlAttribute("TestTypeId")]
        [Bindable(true)]
        public int TestTypeId
        {
            get { return GetColumnValue<int>(Columns.TestTypeId); }
            set { SetColumnValue(Columns.TestTypeId, value); }
        }

        [XmlAttribute("DataSequence")]
        [Bindable(true)]
        public int? DataSequence
        {
            get { return GetColumnValue<int?>(Columns.DataSequence); }
            set { SetColumnValue(Columns.DataSequence, value); }
        }

        [XmlAttribute("DataName")]
        [Bindable(true)]
        public string DataName
        {
            get { return GetColumnValue<string>(Columns.DataName); }
            set { SetColumnValue(Columns.DataName, value); }
        }

        [XmlAttribute("MeasureUnit")]
        [Bindable(true)]
        public string MeasureUnit
        {
            get { return GetColumnValue<string>(Columns.MeasureUnit); }
            set { SetColumnValue(Columns.MeasureUnit, value); }
        }

        [XmlAttribute("DataPoint")]
        [Bindable(true)]
        public short DataPoint
        {
            get { return GetColumnValue<short>(Columns.DataPoint); }
            set { SetColumnValue(Columns.DataPoint, value); }
        }

        [XmlAttribute("NormalLevel")]
        [Bindable(true)]
        public string NormalLevel
        {
            get { return GetColumnValue<string>(Columns.NormalLevel); }
            set { SetColumnValue(Columns.NormalLevel, value); }
        }

        [XmlAttribute("NormalLevelW")]
        [Bindable(true)]
        public string NormalLevelW
        {
            get { return GetColumnValue<string>(Columns.NormalLevelW); }
            set { SetColumnValue(Columns.NormalLevelW, value); }
        }

        [XmlAttribute("DataView")]
        [Bindable(true)]
        public bool? DataView
        {
            get { return GetColumnValue<bool?>(Columns.DataView); }
            set { SetColumnValue(Columns.DataView, value); }
        }

        [XmlAttribute("DataPrint")]
        [Bindable(true)]
        public bool? DataPrint
        {
            get { return GetColumnValue<bool?>(Columns.DataPrint); }
            set { SetColumnValue(Columns.DataPrint, value); }
        }

        [XmlAttribute("Description")]
        [Bindable(true)]
        public string Description
        {
            get { return GetColumnValue<string>(Columns.Description); }
            set { SetColumnValue(Columns.Description, value); }
        }

        #endregion

        #region ObjectDataSource support

        /// <summary>
        ///     Inserts a record, can be used with the Object Data Source
        /// </summary>
        public static void Insert(string varTestDataId, int varTestTypeId, int? varDataSequence, string varDataName,
            string varMeasureUnit, short varDataPoint, string varNormalLevel, string varNormalLevelW, bool? varDataView,
            bool? varDataPrint, string varDescription)
        {
            var item = new LStandardTest();

            item.TestDataId = varTestDataId;

            item.TestTypeId = varTestTypeId;

            item.DataSequence = varDataSequence;

            item.DataName = varDataName;

            item.MeasureUnit = varMeasureUnit;

            item.DataPoint = varDataPoint;

            item.NormalLevel = varNormalLevel;

            item.NormalLevelW = varNormalLevelW;

            item.DataView = varDataView;

            item.DataPrint = varDataPrint;

            item.Description = varDescription;


            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        ///     Updates a record, can be used with the Object Data Source
        /// </summary>
        public static void Update(string varTestDataId, int varTestTypeId, int? varDataSequence, string varDataName,
            string varMeasureUnit, short varDataPoint, string varNormalLevel, string varNormalLevelW, bool? varDataView,
            bool? varDataPrint, string varDescription)
        {
            var item = new LStandardTest();

            item.TestDataId = varTestDataId;

            item.TestTypeId = varTestTypeId;

            item.DataSequence = varDataSequence;

            item.DataName = varDataName;

            item.MeasureUnit = varMeasureUnit;

            item.DataPoint = varDataPoint;

            item.NormalLevel = varNormalLevel;

            item.NormalLevelW = varNormalLevelW;

            item.DataView = varDataView;

            item.DataPrint = varDataPrint;

            item.Description = varDescription;

            item.IsNew = false;
            if (HttpContext.Current != null)
                item.Save(HttpContext.Current.User.Identity.Name);
            else
                item.Save(Thread.CurrentPrincipal.Identity.Name);
        }

        #endregion

        #region Typed Columns

        public static TableSchema.TableColumn TestDataIdColumn
        {
            get { return Schema.Columns[0]; }
        }


        public static TableSchema.TableColumn TestTypeIdColumn
        {
            get { return Schema.Columns[1]; }
        }


        public static TableSchema.TableColumn DataSequenceColumn
        {
            get { return Schema.Columns[2]; }
        }


        public static TableSchema.TableColumn DataNameColumn
        {
            get { return Schema.Columns[3]; }
        }


        public static TableSchema.TableColumn MeasureUnitColumn
        {
            get { return Schema.Columns[4]; }
        }


        public static TableSchema.TableColumn DataPointColumn
        {
            get { return Schema.Columns[5]; }
        }


        public static TableSchema.TableColumn NormalLevelColumn
        {
            get { return Schema.Columns[6]; }
        }


        public static TableSchema.TableColumn NormalLevelWColumn
        {
            get { return Schema.Columns[7]; }
        }


        public static TableSchema.TableColumn DataViewColumn
        {
            get { return Schema.Columns[8]; }
        }


        public static TableSchema.TableColumn DataPrintColumn
        {
            get { return Schema.Columns[9]; }
        }


        public static TableSchema.TableColumn DescriptionColumn
        {
            get { return Schema.Columns[10]; }
        }

        #endregion

        #region Columns Struct

        public struct Columns
        {
            public static string TestDataId = @"TestData_ID";
            public static string TestTypeId = @"TestType_ID";
            public static string DataSequence = @"Data_Sequence";
            public static string DataName = @"Data_Name";
            public static string MeasureUnit = @"Measure_Unit";
            public static string DataPoint = @"Data_Point";
            public static string NormalLevel = @"Normal_Level";
            public static string NormalLevelW = @"Normal_LevelW";
            public static string DataView = @"Data_View";
            public static string DataPrint = @"Data_Print";
            public static string Description = @"Description";
        }

        #endregion

        #region Update PK Collections

        #endregion

        #region Deep Save

        #endregion

        //no foreign key tables defined (0)


        //no ManyToMany tables defined (0)
    }
}