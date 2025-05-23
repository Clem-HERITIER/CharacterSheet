-- Niveau 1 : Pamphlétaire (Bronze 1)
INSERT INTO "CareerLevels"
  ("Id", "Title", "Level", "CareerId", "StatusTier", "StatusLevel", "CanAdvanceCharacteristics")
VALUES
  (1, 'Pamphlétaire', 1, 1, 0, 1, '');

-- Compétences de niveau 1
INSERT INTO "CareerLevelSkills" ("CareerLevelId", "SkillId")
VALUES
  (1, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Art (Écriture)')),
  (1, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Charme')),
  (1, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Marchandage')),
  (1, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Métier (Imprimerie)')),
  (1, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Ragot')),
  (1, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Résistance à l’alcool')),
  (1, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Savoir (Politique)')),
  (1, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Subornation'));

-- Talents de niveau 1
INSERT INTO "CareerLevelTalents" ("CareerLevelId", "TalentId")
VALUES
  (1, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Baratiner')),
  (1, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Faire la manche')),
  (1, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Lire/Écrire')),
  (1, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Sociable'));



-- Niveau 2 : Agitateur (Bronze 2)
INSERT INTO "CareerLevels"
  ("Id", "Title", "Level", "CareerId", "StatusTier", "StatusLevel", "CanAdvanceCharacteristics")
VALUES
  (2, 'Agitateur', 2, 1, 0, 2, '');

-- Compétences de niveau 2
INSERT INTO "CareerLevelSkills" ("CareerLevelId", "SkillId")
VALUES
  (2, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Calme')),
  (2, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Commandement')),
  (2, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Divertissement (Narration)')),
  (2, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Esquive')),
  (2, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Intuition')),
  (2, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Pari'));

-- Talents de niveau 2
INSERT INTO "CareerLevelTalents" ("CareerLevelId", "TalentId")
VALUES
  (2, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Chat de gouttière')),
  (2, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Ergoteur')),
  (2, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Ferveur ardente')),
  (2, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Orateur'));

-- Niveau 3 : Fauteur de Troubles (Bronze 3)
INSERT INTO "CareerLevels"
  ("Id", "Title", "Level", "CareerId", "StatusTier", "StatusLevel", "CanAdvanceCharacteristics")
VALUES
  (3, 'Fauteur de Troubles', 3, 1, 0, 3, '');

-- Compétences de niveau 3
INSERT INTO "CareerLevelSkills" ("CareerLevelId", "SkillId")
VALUES
  (3, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Athlétisme')),
  (3, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Corps à corps (Bagarre)')),
  (3, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Intimidation')),
  (3, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Perception'));

-- Talents de niveau 3
INSERT INTO "CareerLevelTalents" ("CareerLevelId", "TalentId")
VALUES
  (3, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Combat déloyal')),
  (3, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Fuite !')),
  (3, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Menteur')),
  (3, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Pas de côté'));



-- Niveau 4 : Démagogue (Bronze 5)
INSERT INTO "CareerLevels"
  ("Id", "Title", "Level", "CareerId", "StatusTier", "StatusLevel", "CanAdvanceCharacteristics")
VALUES
  (4, 'Démagogue', 4, 1, 0, 5, '');

-- Compétences de niveau 4
INSERT INTO "CareerLevelSkills" ("CareerLevelId", "SkillId")
VALUES
  (4, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Chevaucher (Cheval)')),
  (4, (SELECT "Id" FROM "Skills" WHERE "Name" = 'Savoir (Héraldique)'));

-- Talents de niveau 4
INSERT INTO "CareerLevelTalents" ("CareerLevelId", "TalentId")
VALUES
  (4, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Affable')),
  (4, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Grand orateur')),
  (4, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Intrigant')),
  (4, (SELECT "Id" FROM "Talents" WHERE "Name" = 'Savoir-vivre'));