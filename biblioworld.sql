-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : ven. 17 jan. 2025 à 22:35
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `biblioworld`
--

-- --------------------------------------------------------

--
-- Structure de la table `books`
--

CREATE TABLE `books` (
  `BookID` int(11) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `PublishedYear` int(11) NOT NULL,
  `Summary` text NOT NULL,
  `image_book_url` text NOT NULL,
  `PurchaseLink` varchar(500) DEFAULT NULL,
  `AuthorName` varchar(255) NOT NULL,
  `GenreName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `books`
--

INSERT INTO `books` (`BookID`, `Title`, `PublishedYear`, `Summary`, `image_book_url`, `PurchaseLink`, `AuthorName`, `GenreName`) VALUES
(1, '1984', 1949, '\"1984\" est un roman dystopique qui plonge le lecteur dans un monde totalitaire où le Parti, dirigé par Big Brother, exerce un contrôle absolu sur la société. Winston Smith, le protagoniste, travaille au Ministère de la Vérité où il falsifie les archives historiques pour aligner le passé sur les directives du Parti. Dans un univers où la pensée indépendante est réprimée par la \"police de la pensée\" et où la manipulation du langage à travers la \"novlangue\" réduit la capacité de réflexion, Winston tente de résister. Sa relation secrète avec Julia et sa quête de vérité le conduisent à découvrir l\'implacable pouvoir du système. Orwell dépeint ainsi les dérives extrêmes d\'un régime autoritaire et les dangers de la surveillance généralisée.\r\n\r\n', 'https://static.fnac-static.com/multimedia/PE/Images/FR/NR/10/35/01/79120/1507-1/tsp20250103092736/1984.jpg', 'https://www.amazon.fr/1984-George-Orwell/dp/207036822X', 'George Orwell', 'Dystopie, Science-fiction'),
(2, 'Le Petit Prince', 1943, 'Ce conte philosophique raconte l\'histoire d\'un aviateur échoué dans le désert du Sahara qui rencontre un petit prince venu d\'une autre planète. Au fil de leurs discussions, le Petit Prince relate ses voyages de planète en planète, où il rencontre divers personnages représentant les travers des adultes : un roi, un vaniteux, un buveur, un homme d\'affaires, un allumeur de réverbères, et un géographe. À travers ces récits, Saint-Exupéry aborde des thèmes profonds comme l\'amitié, l\'amour, la perte, et le sens de la vie. Le roman met en lumière la pureté du regard enfantin face à l\'absurdité du monde adulte.', 'https://static.fnac-static.com/multimedia/PE/Images/FR/NR/a6/d8/1d/1956006/1507-1/tsp20241211074117/Le-Petit-Prince.jpg', 'https://www.amazon.fr/petit-prince-Antoine-Saint-Exup%C3%A9ry/dp/2070612759', 'Antoine de Saint-Exupéry', 'Conte philosophique'),
(3, 'Moby Dick', 1851, 'Ce roman d\'aventure épique suit Ishmael, un marin engagé sur le baleinier Pequod commandé par le capitaine Achab. Obsédé par sa quête de vengeance contre Moby Dick, un gigantesque cachalot blanc qui lui a coûté une jambe, Achab entraîne son équipage dans une chasse impitoyable. Le roman explore des thèmes tels que la folie, la vengeance, la nature indomptable de la mer et la lutte de l\'homme contre des forces qui le dépassent. À travers une narration dense et philosophique, Melville questionne la place de l\'homme face à l\'infini et l\'absurdité de certaines quêtes humaines.', 'https://m.media-amazon.com/images/I/81dYQsEpgkL._AC_UF894,1000_QL80_.jpg', 'https://www.amazon.fr/gp/product/2070400662?ie=UTF8&tag=babelio-21&linkCode=as2&camp=1642&creative=6746&creativeASIN=2070400662', 'Herman Melville', 'Aventure, Roman maritime'),
(4, 'Pride and Prejudice', 1813, 'Ce classique de la littérature anglaise dépeint les relations sociales et les mariages dans la société britannique du XIXe siècle. L\'histoire suit Elizabeth Bennet, une jeune femme vive et indépendante, et sa relation complexe avec le riche et mystérieux Mr. Darcy. Entre malentendus, préjugés sociaux et orgueil personnel, leur histoire met en lumière les contraintes sociales pesant sur les femmes de l\'époque et les attentes en matière de mariage. Austen critique subtilement les normes sociales tout en offrant une romance captivante et intemporelle.', 'https://m.media-amazon.com/images/I/81NLDvyAHrL.jpg', 'https://www.amazon.fr/Orgueil-Pr%C3%A9jug%C3%A9s-Pride-Prejudice-Austen/dp/1549649094', 'Jane Austen', 'Romance, Littérature classique'),
(5, 'To Kill a Mockingbird', 1960, 'Situé dans l\'Alabama des années 1930, ce roman aborde les thèmes du racisme et de l\'injustice à travers les yeux de Scout Finch, une jeune fille vive et curieuse. Son père, Atticus Finch, avocat intègre, défend un homme noir accusé à tort d\'avoir agressé une femme blanche. Le récit explore la perte de l\'innocence face à la cruauté du monde adulte, tout en soulignant l\'importance de la tolérance et de l\'empathie. Harper Lee dresse un portrait poignant des tensions raciales et des inégalités sociales dans le Sud des États-Unis.', 'https://m.media-amazon.com/images/I/71FxgtFKcQL._AC_UF1000,1000_QL80_.jpg', 'https://www.amazon.fr/Kill-Mockingbird-Harper-Lee/dp/0446310786', 'Harper Lee', 'Drame, Roman social'),
(6, 'Le Grand Test', 2021, 'Ce thriller psychologique haletant suit plusieurs candidats qui participent à une mystérieuse épreuve censée révéler la vraie nature de chacun. Peu à peu, les participants découvrent que ce test n\'est pas ce qu\'il semble être et que des enjeux bien plus sombres se cachent derrière. Le roman plonge le lecteur dans une ambiance oppressante où manipulation, secrets et révélations s\'entremêlent, offrant une réflexion sur les limites humaines et les choix moraux face au danger.', 'https://www.livredepoche.com/sites/default/files/styles/manual_crop_269_435/public/images/livres/couv/9782253249801-001-T.jpeg?itok=8jGRagcX', 'https://www.amazon.fr/Grand-Test-Jacques-Expert/dp/2702185282', 'Jacques Expert', 'Thriller psychologique'),
(7, 'Demain', 2013, 'Ce roman mêle habilement suspense et romance. Matthew, un professeur de philosophie endeuillé, achète un ordinateur d\'occasion qui contient encore les fichiers de son ancienne propriétaire, Emma. En échangeant des messages, ils réalisent qu\'ils vivent à un an d\'écart. Matthew tente alors désespérément de modifier le cours des événements pour sauver Emma d\'un destin tragique. Musso explore le thème du destin, des coïncidences et de l\'amour à travers une intrigue captivante et pleine de rebondissements.', 'https://m.media-amazon.com/images/I/61ogVp+mL7L._AC_UF1000,1000_QL80_.jpg', 'https://www.amazon.fr/gp/product/2266246887?ie=UTF8&tag=babelio-21&linkCode=as2&camp=1642&creative=6746&creativeASIN=2266246887', 'Guillaume Musso', 'Suspense, Romance'),
(8, 'L\'Adversaire', 2000, 'Inspiré d\'une histoire vraie, ce roman retrace l\'affaire Jean-Claude Romand, un homme qui a vécu pendant des années dans le mensonge, prétendant être médecin et chercheur à l\'OMS. Quand ses mensonges sont sur le point d\'être découverts, il assassine sa famille et tente de se suicider. Carrère explore avec finesse les méandres de la psychologie humaine, le poids du mensonge et la construction d\'une identité fictive. Ce récit glaçant questionne la nature du mal et les failles de l\'être humain.\r\n\r\n', 'https://m.media-amazon.com/images/I/81RhSNHVQZL.jpg', 'https://www.amazon.fr/gp/product/2073033512?ie=UTF8&tag=babelio-21&linkCode=as2&camp=1642&creative=6746&creativeASIN=2073033512', 'Emmanuel Carrère', 'Roman basé sur des faits réels'),
(9, 'Le Meilleur Moi', 2023, 'Et si la meilleure version de vous-même existait déjà, quelque part, enfouie sous vos doutes et vos peurs ? Dans _Le Meilleur Moi_, Rose Pernot nous invite à un voyage profond et émouvant au cœur de soi. Ce livre explore les chemins de la résilience, de la confiance en soi et du dépassement des limites que l\'on s\'impose. Un guide inspirant pour révéler la meilleure version de soi.', 'https://m.media-amazon.com/images/I/71I8t5SvyNL._AC_UF894,1000_QL80_.jpg', 'https://www.amazon.fr/meilleur-moi-Rose-Pernot/dp/1777333342', 'Rose Pernot', 'Développement personnel');

-- --------------------------------------------------------

--
-- Structure de la table `saved_books`
--

CREATE TABLE `saved_books` (
  `SaveID` int(11) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `BookID` int(11) DEFAULT NULL,
  `SavedAt` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `saved_books`
--

INSERT INTO `saved_books` (`SaveID`, `UserID`, `BookID`, `SavedAt`) VALUES
(1, 1, 1, '2025-01-13 23:35:23'),
(2, 1, 2, '2025-01-14 20:44:51'),
(3, 1, 3, '2025-01-14 21:41:49'),
(4, 1, 4, '2025-01-14 23:47:58'),
(5, 1, 6, '2025-01-15 00:55:42'),
(6, 1, 8, '2025-01-15 02:13:38');

-- --------------------------------------------------------

--
-- Structure de la table `userbooks`
--

CREATE TABLE `userbooks` (
  `UserBookID` int(11) NOT NULL,
  `UserID` int(11) NOT NULL,
  `BookID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Role` enum('Admin','Lecteur') DEFAULT 'Lecteur'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`UserID`, `Username`, `Email`, `Password`, `Role`) VALUES
(1, 'testuser', '', 'password123', 'Lecteur'),
(2, 'admin', 'admin@example.com', 'admin123', 'Admin');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`BookID`);

--
-- Index pour la table `saved_books`
--
ALTER TABLE `saved_books`
  ADD PRIMARY KEY (`SaveID`),
  ADD KEY `UserID` (`UserID`),
  ADD KEY `BookID` (`BookID`);

--
-- Index pour la table `userbooks`
--
ALTER TABLE `userbooks`
  ADD PRIMARY KEY (`UserBookID`);

--
-- Index pour la table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `books`
--
ALTER TABLE `books`
  MODIFY `BookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT pour la table `saved_books`
--
ALTER TABLE `saved_books`
  MODIFY `SaveID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT pour la table `userbooks`
--
ALTER TABLE `userbooks`
  MODIFY `UserBookID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `saved_books`
--
ALTER TABLE `saved_books`
  ADD CONSTRAINT `saved_books_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  ADD CONSTRAINT `saved_books_ibfk_2` FOREIGN KEY (`BookID`) REFERENCES `books` (`BookID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
