using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GraphQL.Types;
using MyAirport.EF;


namespace MyAirportGraphQl2.GraphQlType
{
   
    public class VolType : ObjectGraphType <Vol>
    {
        public VolType()
        {
            Field(x => x.VolId);
      /*  Field(x => x.Classe);
        Field(x => x.CodeIata);
        Field(x => x.DateCreation);
        Field(x => x.Destination);
        Field(x => x.Escale);
        Field(x => x.Prioritaire);
        Field(x => x.Status);
        Field(x => x.StatusSurete);
        Field(x => x.VolId);
        */
    }
    }
}
