CREATE DATABASE bmi_calculator_db
GO
USE bmi_calculator_db
GO
CREATE TABLE bmi_calculator_history (
	bmi_id INT IDENTITY(1,1) PRIMARY KEY,
	height_cm DECIMAL(18,3),
	weight_kg DECIMAL(18,3),
	bmi_score DECIMAL(18,1) NOT NULL,
	bmi_time DATETIME NOT NULL
)