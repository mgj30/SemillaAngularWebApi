using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SemillaAngularWebApi.API.DB.Schema_info
{
    public class Column_info
    {
        public String TABLE_CATALOG{get;set;}
        public String TABLE_SCHEMA{get;set;}
        public String TABLE_NAME{get;set;}
        public String COLUMN_NAME{get;set;}
        public String ORDINAL_POSITION{get;set;}
        public String COLUMN_DEFAULT{get;set;}
        public String IS_NULLABLE{get;set;}
        public String DATA_TYPE{get;set;}
        public String CHARACTER_MAXIMUM_LENGTH{get;set;}
        public String CHARACTER_OCTET_LENGTH{get;set;}
        public String NUMERIC_PRECISION{get;set;}
        public String NUMERIC_SCALE{get;set;}
        public String DATETIME_PRECISION{get;set;}
        public String CHARACTER_SET_NAME{get;set;}
        public String COLLATION_NAME{get;set;}
        public String COLUMN_TYPE{get;set;}
        public String COLUMN_KEY{get;set;}
        public String EXTRA{get;set;}
        public String PRIVILEGES{get;set;}
        public String COLUMN_COMMENT{get;set;}
    }
}