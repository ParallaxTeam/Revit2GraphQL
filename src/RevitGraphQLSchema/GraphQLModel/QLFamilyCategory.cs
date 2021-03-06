﻿using System.Collections.Generic;

namespace RevitGraphQLSchema.GraphQLModel
{
    public class QLFamilyCategory
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<QLFamily> qlFamilies { get; set; }

        public List<QLFamilyInstance> qlFamilyInstances { get; set; }

    }
}