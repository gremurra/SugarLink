namespace SugarLink.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorGuidMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Patient", "DoctorId", "dbo.Doctor");
            DropIndex("dbo.Patient", new[] { "DoctorId" });
            DropPrimaryKey("dbo.Doctor");
            AlterColumn("dbo.Doctor", "DoctorId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Patient", "DoctorId", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Doctor", "DoctorId");
            CreateIndex("dbo.Patient", "DoctorId");
            AddForeignKey("dbo.Patient", "DoctorId", "dbo.Doctor", "DoctorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patient", "DoctorId", "dbo.Doctor");
            DropIndex("dbo.Patient", new[] { "DoctorId" });
            DropPrimaryKey("dbo.Doctor");
            AlterColumn("dbo.Patient", "DoctorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Doctor", "DoctorId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Doctor", "DoctorId");
            CreateIndex("dbo.Patient", "DoctorId");
            AddForeignKey("dbo.Patient", "DoctorId", "dbo.Doctor", "DoctorId", cascadeDelete: true);
        }
    }
}
