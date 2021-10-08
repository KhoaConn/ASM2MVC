namespace ASM2MVC.EF.SystemMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FPTSystem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseName = c.String(nullable: false, maxLength: 50, unicode: false),
                        CourseCategory = c.String(nullable: false, maxLength: 50, unicode: false),
                        Description = c.String(nullable: false, maxLength: 300, unicode: false),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO dbo.Courses (CourseName, CourseCategory, Description) VALUES " +
                "('Application Development', 'Computing', 'Application development is the process of creating a computer program or a set of programs to perform the different tasks that a business requires.'), " +
                "('Business Intelligence', 'Computing' , 'Business intelligence (BI) leverages software and services to transform data into actionable insights that inform an organization’s strategic and tactical business decisions.'), " +
                "('Marketing', 'Business', '.....')");

            CreateTable(
                "dbo.MTrainees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TraineeName = c.String(nullable: false, maxLength: 50, unicode: false),
                        UserName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Age = c.Int(nullable: false),
                        DOB = c.String(nullable: false, maxLength: 50, unicode: false),
                        Mainlanguage = c.String(nullable: false, maxLength: 50, unicode: false),
                        TOEICScore = c.Int(nullable: false),
                        Department = c.String(nullable: false, maxLength: 50, unicode: false),
                        Location = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO dbo.MTrainees (TraineeName, UserName, Age, DOB, Mainlanguage, TOEICScore, Department, Location) VALUES " +
                "('Nam Nguyen', 'UserName1', 24, '22/01/2001', 'Java', 7, 'Computing', 'My Dinh Street'), " +
                "('Tran Nguyen', 'UserName2', 22, '22/05/2000', 'C#', 8, 'Computing', 'Me Tri Street'), " +
                "('Tri Nguyen', 'UserName3', 20, '27/08/2001', 'JavaScrips', 6, 'Computing', 'Thai Nguyen City') ");
                

            CreateTable(
                "dbo.MTrainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrainerName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Type = c.String(),
                        WorkingPlace = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telephone = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO dbo.MTrainers (TrainerName, Type, WorkingPlace, Telephone, Email) VALUES " +
                "('John Wick', 'External', 'FPT', 0964055483, 'Nguyendangkhoa2027@gmal.com'), " +
                "('Nick Wick', 'Internal', 'FPT', 0964055483, 'nickwater2027@gmal.com'), " +
                "('Ben Bean', 'Internal', 'FPT', 0964055483, 'Beanb12@gmal.com') ");

            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TopicName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Description = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO dbo.Topics (TopicName, Description) VALUES" +
                "('Computing', 'IT...')," +
                "('Design', 'Photoshop...')," +
                "('Business', 'Marketing...')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Topics");
            DropTable("dbo.MTrainers");
            DropTable("dbo.MTrainees");
            DropTable("dbo.Courses");
        }
    }
}
