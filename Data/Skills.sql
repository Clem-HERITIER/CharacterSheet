INSERT INTO "Skills" ("Name", "ShortDescription", "Description", "Characteristic", "IsGrouped", "Specialization", "IsAdvanced") VALUES

-- Art
('Art', 'Création artistique selon spécialisation', 'Créez des oeuvres d’art avec le moyen d’expression de votre choix. Tests modifiés si outils absents. DR détermine la qualité. Peut nécessiter un Test étendu.', 6, TRUE, 'Cartographie, Gravure, Mosaïque, Peinture, Sculpture, Tatouage, Tissage', FALSE),

-- Athlétisme
('Athlétisme', 'Activité physique générale', 'Permet de courir, sauter, se déplacer rapidement. Influencé par les règles de mouvement.', 5, FALSE, NULL, FALSE),

-- Calme
('Calme', 'Résister à la peur et rester serein', 'Permet de garder son sang-froid sous pression, résister à la peur et à la psychologie.', 8, FALSE, NULL, FALSE),

-- Charme
('Charme', 'Influencer positivement autrui', 'Utilisé pour plaire, persuader ou mendier. Peut s'utiliser en public ou en combat selon le contexte.', 9, FALSE, NULL, FALSE),

-- Chevaucher
('Chevaucher', 'Maîtrise des montures spécifiques', 'Utilisé pour monter et contrôler des animaux montables. Nécessaire pour les actions inhabituelles.', 5, TRUE, 'Cheval, Grand Loup, Griffon, Demigriffon, Pégase', FALSE),

-- Commandement
('Commandement', 'Donner des ordres efficacement', 'Permet de diriger d'autres individus, conférer des Avantages et encourager les alliés.', 9, FALSE, NULL, FALSE),

-- Conduite d’attelage
('Conduite d’attelage', 'Contrôle de véhicules attelés', 'Permet de conduire chariots et diligences. Les tests dépendent de l'état de la route et de la météo.', 5, FALSE, NULL, FALSE),

-- Corps à corps
('Corps à corps', 'Maîtrise des armes de mêlée', 'Utilisé pour le combat rapproché selon une spécialisation. Pénalités si mauvaise spécialisation.', 0, TRUE, 'Arme d’hast, Arme à deux mains, Bagarre, Base, Cavalerie, Escrime, Fléau, Parade', FALSE),

-- Crochetage
('Crochetage', 'Ouvrir serrures sans clefs', 'Utilisé pour forcer des mécanismes de verrouillage. Les outils inappropriés imposent un malus.', 6, FALSE, NULL, TRUE),

-- Discrétion
('Discrétion', 'Se cacher et se faufiler', 'Permet de se mouvoir sans être détecté, souvent opposée à Perception.', 5, TRUE, 'Rurale, Souterrains, Urbaine', FALSE),

-- Divertissement
('Divertissement', 'Captiver un public par une performance', 'Permet d'amuser ou de captiver les foules. Utilisable selon la spécialisation choisie.', 9, TRUE, 'Chant, Comédie, Interprétation, Narration', FALSE),

-- Dressage
('Dressage', 'Entraînement d'animaux spécifiques', 'Permet d'entraîner des animaux. Peut provoquer la peur chez une bête ciblée en combat.', 7, TRUE, 'Cheval, Chien, Demigriffon, Pégase, Pigeon', TRUE),

-- Emprise sur les animaux
('Emprise sur les animaux', 'Calmer ou dominer les animaux', 'Influence comportement des animaux. Peut les empêcher d’attaquer pendant un round.', 8, FALSE, NULL, FALSE),

-- Escalade
('Escalade', 'Grimper sur des surfaces', 'Permet d'escalader en sécurité. Requiert des tests si la surface est difficile ou en combat.', 2, FALSE, NULL, FALSE),

-- Escamotage
('Escamotage', 'Vol discret et tours de passe-passe', 'Permet de faire les poches ou de tricher. Peut être utilisé avec Pari.', 6, FALSE, NULL, TRUE),

-- Esquive
('Esquive', 'Éviter des attaques ou dangers', 'Utilisée pour éviter les attaques en combat ou obstacles imprévus.', 5, FALSE, NULL, FALSE),

-- Évaluation
('Évaluation', 'Déterminer la valeur d'objets', 'Permet d'estimer la valeur d'objets rares ou falsifiés.', 7, FALSE, NULL, TRUE),

-- Focalisation
('Focalisation', 'Contrôle des Vents de Magie', 'Permet de canaliser les Vents de Magie. Essentielle pour les lanceurs de sorts.', 8, TRUE, 'Aqshy, Azyr, Chamon, Dhar, Ghur, Ghyran, Hysh, Shyish, Ulgu', TRUE),

-- Guérison
('Guérison', 'Soigner blessures et maladies', 'Permet de traiter maladies, blessures et infections.', 7, FALSE, NULL, TRUE),

-- Intimidation
('Intimidation', 'Contraindre par la peur', 'Permet de forcer une créature à se soumettre ou fuir.', 2, FALSE, NULL, FALSE),

-- Intuition
('Intuition', 'Percevoir ce qui est implicite', 'Permet de remarquer les mensonges ou les dangers potentiels.', 7, FALSE, NULL, FALSE),

-- Langue
('Langue', 'Comprendre et parler d'autres langues', 'Permet de communiquer dans une langue donnée. Utilisé pour concepts complexes.', 7, TRUE, 'bataille, bretonnien, classique, guilde, khazalid, Magick, voleur, tiléen', TRUE),

-- Marchandage
('Marchandage', 'Négocier de meilleures offres', 'Utilisé pour obtenir de bons prix ou déceler les arnaques.', 9, FALSE, NULL, FALSE),

-- Métier
('Métier', 'Exercer un métier ou artisanat', 'Permet de fabriquer des objets ou rendre des services professionnels.', 6, TRUE, 'Apothicaire, Calligraphe, Cirier, Charpentier, Cuisinier, Embaumeur, Forgeron, Tanneur', TRUE),

-- Musicien
('Musicien', 'Jouer d'un instrument', 'Permet de divertir avec un instrument de musique.', 6, TRUE, 'Clavecin, Cor, Cornemuse, Luth, Violon', TRUE),

-- Natation
('Natation', 'Nager sans se noyer', 'Permet de nager efficacement. Utile en combat aquatique.', 2, FALSE, NULL, TRUE),

-- Orientation
('Orientation', 'Trouver son chemin', 'Permet de se repérer dans la nature ou avec une carte.', 7, FALSE, NULL, FALSE),

-- Pari
('Pari', 'Évaluer les chances de gains', 'Utilisé pour jeux de hasard ou spéculations.', 7, FALSE, NULL, FALSE),

-- Perception
('Perception', 'Détecter les choses par les sens', 'Permet d'observer et repérer des dangers ou anomalies.', 7, FALSE, NULL, FALSE);