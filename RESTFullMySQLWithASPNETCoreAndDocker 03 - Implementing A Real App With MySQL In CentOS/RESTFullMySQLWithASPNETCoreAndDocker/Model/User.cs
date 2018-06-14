﻿using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTFullMySQLWithASPNETCoreAndDocker.Model
{
	[Table("users")]
    public class User
    {

        public long? Id { get; set; }
        public string Login { get; set; }
        public string AccessKey { get; set; }
    }
}
