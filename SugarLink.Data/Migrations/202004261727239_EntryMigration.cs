namespace SugarLink.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntryMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Entry", "PatientId", "dbo.Patient");
            DropPrimaryKey("dbo.Entry");
            AddColumn("dbo.Patient", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.Patient", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Entry", "EntryId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Entry", "PatientId");
            AddForeignKey("dbo.Entry", "PatientId", "dbo.Patient", "PatientId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entry", "PatientId", "dbo.Patient");
            DropPrimaryKey("dbo.Entry");
            AlterColumn("dbo.Entry", "EntryId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Patient", "LastName");
            DropColumn("dbo.Patient", "FirstName");
            AddPrimaryKey("dbo.Entry", "EntryId");
            AddForeignKey("dbo.Entry", "PatientId", "dbo.Patient", "PatientId", cascadeDelete: true);
        }
    }
}
