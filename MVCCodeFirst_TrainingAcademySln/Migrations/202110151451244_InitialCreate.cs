namespace MVCCodeFirst_TrainingAcademySln.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "StudentName", c => c.String());
            AlterColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Trainers", "TrainerName", c => c.String(maxLength: 25));
            AlterColumn("dbo.Trainers", "PhoneNumber", c => c.String(maxLength: 11));
            AlterColumn("dbo.Trainings", "TrainingName", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trainings", "TrainingName", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Trainers", "PhoneNumber", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Trainers", "TrainerName", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "StudentName", c => c.String(nullable: false));
        }
    }
}
