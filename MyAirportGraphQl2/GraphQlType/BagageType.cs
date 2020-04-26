using Microsoft.AspNetCore.Mvc;
using GraphQL.Types;
using MyAirport.EF;

namespace MyAirportGraphQl2.GraphQlType
{

    public class BagageType : ObjectGraphType<Bagage>
    {
        public BagageType()
        {
            Field(x => x.BagageId);
               Field(x => x.Classe);
              Field(x => x.CodeIata);
              Field(x => x.DateCreation);
              Field(x => x.Destination);
              Field(x => x.Escale);
              Field(x => x.Prioritaire);
              Field(x => x.Status);
              Field(x => x.StatusSurete);
              Field(x => x.VolId);
              
        }
    }
}
