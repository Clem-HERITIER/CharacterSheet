-- Races
INSERT INTO "Races" ("Name", "Movement", "FatePoints", "ResiliencePoints", "ExtraPoints") VALUES
('Humains', 4, 2, 1, 3),
('Nains', 3, 0, 2, 2),
('Hauts Elfes', 5, 0, 0, 2),
('Elfes Sylvains', 5, 0, 0, 2),
('Halflings', 3, 0, 2, 3);

-- RaceSkills
INSERT INTO "RacesSkills" ("RaceId", "SkillId") VALUES
((SELECT "Id" FROM "Races" WHERE "Name" = 'Humains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Calme')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Humains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Charme')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Humains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Commandement')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Humains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Corps à corps')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Humains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Évaluation')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Humains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Langue')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Humains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Marchandage')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Humains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Projectiles')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Humains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Ragot')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Humains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Savoir')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Humains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Soin aux animaux')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Nains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Calme')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Nains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Corps à corps')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Nains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Divertissement')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Nains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Évaluation')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Nains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Intimidation')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Nains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Langue')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Nains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Métier')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Nains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Résistance')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Nains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Résistance à l’alcool')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Nains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Savoir')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Halflings'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Charme')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Halflings'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Discrétion')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Halflings'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Escamotage')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Halflings'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Esquive')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Halflings'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Intuition')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Halflings'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Langue')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Halflings'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Marchandage')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Halflings'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Métier')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Halflings'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Pari')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Halflings'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Perception')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Halflings'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Résistance à l’alcool')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Halflings'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Savoir')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Hauts Elfes'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Calme')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Hauts Elfes'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Commandement')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Hauts Elfes'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Corps à corps')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Hauts Elfes'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Divertissement')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Hauts Elfes'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Évaluation')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Hauts Elfes'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Musicien')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Hauts Elfes'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Langue')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Hauts Elfes'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Natation')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Hauts Elfes'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Orientation')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Hauts Elfes'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Perception')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Hauts Elfes'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Projectiles')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Hauts Elfes'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Voile')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Elfes Sylvains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Athlétisme')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Elfes Sylvains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Corps à corps')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Elfes Sylvains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Discrétion')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Elfes Sylvains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Divertissement')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Elfes Sylvains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Escalade')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Elfes Sylvains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Intimidation')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Elfes Sylvains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Langue')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Elfes Sylvains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Perception')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Elfes Sylvains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Pistage')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Elfes Sylvains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Projectiles')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Elfes Sylvains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Résistance')),
((SELECT "Id" FROM "Races" WHERE "Name" = 'Elfes Sylvains'), (SELECT "Id" FROM "Skills" WHERE "Name" = 'Survie en extérieur'));
