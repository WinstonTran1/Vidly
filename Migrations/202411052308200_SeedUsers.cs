namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8e7e2978-255d-490f-9809-79cbd0e70a8c', N'admin@vidly.com', 0, N'AC3UDDi05xafOnDdeYve1oJd5AO5SUd/CRI/jWOsSXfvvNhS9rYWnkLHFUQcGIBHnA==', N'680a2885-3945-4736-9b5a-c526b5e357cc', NULL, 0, 0, NULL, 1, 0, N'admin2@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a9dfdf2a-835d-4356-9a60-8b8e3d48d847', N'guest@vidly.com', 0, N'ANh7MjrS3lmk/sNAmZApGdPwfwjVF6+S4ecqi3T6f4shI1hxLhDf5aRb/X2Qr/eqMA==', N'cf1f080f-49b1-4f16-9b39-1e291101f889', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b3c40b77-059c-4670-b38d-cdb22670c4d1', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8e7e2978-255d-490f-9809-79cbd0e70a8c', N'b3c40b77-059c-4670-b38d-cdb22670c4d1')
");
        }
        
        public override void Down()
        {
        }
    }
}
