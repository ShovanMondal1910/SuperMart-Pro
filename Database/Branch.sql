-- PostgreSQL Schema Script for Branch Table
-- Matching Models/Branch.cs

CREATE TABLE IF NOT EXISTS "Branches" (
    "BranchID"      VARCHAR(50) PRIMARY KEY,
    "BranchName"    VARCHAR(100) NOT NULL,
    "BranchType"    VARCHAR(50),
    "BranchAddress" VARCHAR(255) UNIQUE,
    "BranchZip"     VARCHAR(20),
    "BranchPhone"   VARCHAR(20) UNIQUE,
    "BranchEmail"   VARCHAR(100) UNIQUE,
    "IsActive"      BOOLEAN NOT NULL DEFAULT TRUE,
    "ManagerID"     VARCHAR(50) UNIQUE,
    "CreatedBy"     VARCHAR(50),
    "CreatedAt"     TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    "UpdatedBy"     VARCHAR(50),
    "UpdatedAt"     TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
