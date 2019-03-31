namespace WENTE.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class addnewperandphonenumentity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "PB.PersonNumber",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Number = c.String(nullable: false, maxLength: 11),
                        CreationTime = c.DateTime(nullable: false),
                        type = c.Int(nullable: false),
                        personId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("PB.Person", t => t.personId, cascadeDelete: true)
                .Index(t => t.personId);
            
            CreateTable(
                "PB.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        EmailAddress = c.String(maxLength: 200),
                        Address = c.String(maxLength: 200),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Person_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("PB.PersonNumber", "personId", "PB.Person");
            DropIndex("PB.PersonNumber", new[] { "personId" });
            DropTable("PB.Person",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Person_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
            DropTable("PB.PersonNumber");
        }
    }
}
