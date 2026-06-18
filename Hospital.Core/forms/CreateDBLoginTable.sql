-- Create Login Table
IF OBJECT_ID('dbo.dbLogin', 'U') IS NOT NULL
	DROP TABLE dbo.dbLogin;

CREATE TABLE dbo.dbLogin
(
	LoginId INT PRIMARY KEY IDENTITY(1,1),
	Username NVARCHAR(100) NOT NULL UNIQUE,
	Password NVARCHAR(255) NOT NULL,
	IsActive BIT NOT NULL DEFAULT 1,
	CreatedAt DATETIME NOT NULL DEFAULT GETUTCDATE(),
	UpdatedAt DATETIME NOT NULL DEFAULT GETUTCDATE()
);

-- Create Index
CREATE INDEX IX_dbLogin_Username ON dbo.dbLogin(Username);

-- Insert Default Admin User
INSERT INTO dbo.dbLogin (Username, Password, IsActive)
VALUES 
	('admin', 'admin123', 1);

-- Verify Insert
SELECT * FROM dbo.dbLogin;
