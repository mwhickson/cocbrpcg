CREATE TABLE "Characters" (
	"id"	INTEGER NOT NULL UNIQUE,
	"name"	TEXT,
	"birthplace"	TEXT,
	"pronouns"	TEXT,
	"occupation_id"	INTEGER,
	"residence"	TEXT,
	"age"	TEXT,
	"portrait"	BLOB,
	PRIMARY KEY("id" AUTOINCREMENT)
)