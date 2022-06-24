--INSERT INTO DollTypes (Name)
--VALUES
--('HG'),
--('AR'),
--('SMG'),
--('RF'),
--('MG'),
--('SG')

--INSERT INTO DollRarities (Rarity)
--VALUES
--('Extra'),
--('2 Star'),
--('3 Star'),
--('4 Star'),
--('5 Star')

-- Delete all Doll records
--DELETE FROM Dolls

-- Insert all Dolls
--SET IDENTITY_INSERT Dolls ON;

--INSERT INTO Dolls (Id, Name, DollTypeId, DollRarityId)
--VALUES
--(1, 'Colt Revolver', 1, 4),
--(2, 'M1911', 1, 2),
--(3, 'M9', 1, 3),
--(4, 'Python', 1, 5),
--(5, 'M1895', 1, 2),
--(6, 'Tokarev', 1, 3),
--(7, 'Stechkin', 1, 4),
--(8, 'Makarov', 1, 3),
--(9, 'P38', 1, 2),
--(10, 'PPK', 1, 2),
--(11, 'P08', 1, 3),
--(12, 'C96', 1, 3),
--(13, 'Type92', 1, 3),
--(14, 'Astra', 1, 3),
--(15, 'G17', 1, 3),
--(16, 'Thompson', 1, 5),
--(17, 'M3', 1, 2),
--(18, 'Ingram', 3, 3),
--(19, 'FMG-9', 3, 3),
--(20, 'Vector', 3, 5),
--(21, 'PPSh-41', 3, 2),
--(22, 'PPS-43', 3, 3),
--(23, 'PP-90', 3, 4),
--(24, 'PP-2000', 3, 2),
--(25, 'MP40', 3, 2),
--(26, 'Gr MP5', 3, 4),
--(27, 'Skorpion', 3, 3),
--(28, 'Gr MP7', 3, 5),
--(29, 'STEN MkII', 3, 3),
--(31, 'M38', 3, 2),
--(32, 'Micro Uzi', 3, 3),
--(33, 'm45', 3, 2),
--(34, 'M1 Garand', 4, 3),
--(35, 'M1A1', 4, 3),
--(36, 'Springfield', 4, 4),
--(37, 'M14', 4, 3),
--(38, 'M21', 4, 3),
--(39, 'Mosin-Nagant', 4, 4),
--(40, 'SVT-38', 4, 2),
--(41, 'SKS', 4, 2),
--(42, 'PTRD', 4, 4),
--(43, 'SVD', 4, 4),
--(44, 'SV-98', 4, 3),
--(46, 'Kar98k', 4, 5),
--(47, 'G43', 4, 2),
--(48, 'WA2000', 4, 5),
--(49, 'Type56R', 4, 3),
--(50, 'Lee Enfield', 4, 5),
--(51, 'FF FN49', 4, 2),
--(52, 'VM59', 4, 2),
--(53, 'NTW-20', 4, 5),
--(54, 'M16A1', 2, 4),
--(55, 'M4A1', 2, 4),
--(56, 'M4 SOPMOD II', 2, 4),
--(57, 'ST AR-15', 2, 4),
--(58, 'AK-47', 2, 3),
--(59, 'AK-74U', 3, 5),
--(60, 'AS Val', 2, 4),
--(61, 'StG44', 2, 3),
--(62, 'Gr G41', 2, 5),
--(63, 'Gr G3', 2, 2),
--(64, 'Gr G36', 2, 4),
--(65, '416', 2, 5),
--(66, 'Type56-1', 2, 4),
--(68, 'L85A1', 2, 2),
--(69, 'Fr Famas', 2, 4),
--(70, 'FF FNC', 2, 3),
--(71, 'Galil', 2, 2),
--(72, 'TAR-21', 2, 4),
--(73, 'AUG', 2, 5),
--(74, 'SIG-510', 2, 2),
--(75, 'M1918', 5, 4),
--(77, 'M2HB', 5, 3),
--(78, 'M60', 5, 4),
--(79, 'FF M249SAW', 5, 3),
--(80, 'M1919A4', 5, 3),
--(81, 'LWMMG', 5, 2),
--(82, 'DP28', 5, 2),
--(84, 'RPD', 5, 3),
--(85, 'PK', 5, 4),
--(86, 'MG42', 5, 3),
--(87, 'MG34', 5, 2),
--(88, 'MG3', 5, 4),
--(89, 'Bren', 5, 3),
--(90, 'FF FNP9', 1, 2),
--(91, 'MP-446', 1, 2),
--(92, 'Spectre M4', 3, 2),
--(93, 'IDW', 3, 2),
--(94, 'Type64', 3, 2),
--(95, 'Type88', 4, 3),
--(96, 'Grizzly', 1, 5),
--(97, 'M950A', 1, 5),
--(98, 'SPP-1', 1, 4),
--(99, 'Gr Mk23', 1, 4),
--(100, 'P7', 1, 4),
--(101, 'UMP9', 3, 4),
--(102, 'UMP40', 3, 4),
--(103, 'UMP45', 3, 4),
--(104, 'Gr G36c', 3, 5),
--(105, 'OTs-12', 2, 3),
--(106, 'FAL', 2, 5),
--(107, 'FF F2000', 2, 2),
--(108, 'CZ-805', 2, 3),
--(109, 'Gr MG5', 5, 5),
--(110, 'FG42', 5, 2),
--(111, 'AAT-52', 5, 2),
--(112, 'Negev', 5, 5),
--(113, 'Serdyukov', 1, 3),
--(114, 'Welrod MkII', 1, 5),
--(115, 'Suomi', 3, 5),
--(116, 'Z-62', 3, 3),
--(117, 'Gr PSG-1', 4, 4),
--(118, '9A-91', 2, 4),
--(119, 'OTs-14', 2, 5),
--(120, 'ARX-160', 2, 3),
--(121, 'Mk48', 5, 4),
--(122, 'GR G11', 2, 5),
--(123, 'P99', 1, 3),
--(124, 'Super SASS', 4, 3),
--(125, 'Gr MG4', 5, 5),
--(126, 'NZ75', 1, 5),
--(127, 'Type79', 3, 5),
--(128, 'M99', 4, 5),
--(129, 'Type95', 2, 5),
--(130, 'Type97', 2, 5),
--(131, 'EVO 3', 3, 3),
--(132, 'Type59', 1, 3),
--(133, 'Type63', 2, 2),
--(134, 'AR70', 2, 3),
--(135, 'SR-3MP', 3, 5),
--(136, 'PP-19', 3, 4),
--(137, 'PP-19-01', 3, 4),
--(138, '6P62', 2, 3),
--(139, 'Bren Ten', 1, 2),
--(140, 'PSM', 1, 3),
--(141, 'Gr USPCompact', 1, 2),
--(142, 'Five-seven', 1, 5),
--(143, 'RO635', 3, 5),
--(144, 'MT-9', 3, 3),
--(145, 'OTs-44', 4, 3),
--(146, 'Gr G28', 4, 4),
--(147, 'SSG 69', 4, 3),
--(148, 'IWS 2000', 4, 5),
--(149, 'AEK-999', 5, 4),
--(150, 'Shipka', 3, 4),
--(151, 'M1887', 6, 5),
--(152, 'M1897', 6, 3),
--(153, 'M37', 6, 4),
--(154, 'M500', 6, 3),
--(155, 'M590', 6, 4),
--(156, 'Super Shorty', 6, 4),
--(157, 'Am KSG', 6, 5),
--(158, 'KS-23', 6, 3),
--(159, 'RMB-93', 6, 3),
--(160, 'Saiga-12', 6, 5),
--(161, 'Type97S', 6, 4),
--(162, 'SPAS-12', 6, 4),
--(163, 'AA-12', 6, 5),
--(164, 'FP-6', 6, 5),
--(165, 'M1014', 6, 4),
--(166, 'CZ75', 1, 5),
--(167, 'Gr HK45', 1, 3),
--(168, 'Spitfire', 1, 4),
--(169, 'SCW', 3, 3),
--(170, 'ASh-12.7', 2, 3),
--(171, 'Ribeyrolles', 2, 4),
--(172, 'Am RFB', 2, 5),
--(173, 'PKP', 5, 5),
--(174, 'Type81R', 4, 3),
--(175, 'ART556', 2, 5),
--(176, 'TMP', 3, 3),
--(177, 'KLIN', 3, 4),
--(178, 'F1', 3, 3),
--(179, 'DSR-50', 4, 5),
--(180, 'PzB39', 4, 4),
--(181, 'T91', 2, 5),
--(182, 'wz.29', 4, 3),
--(183, 'Contender', 1, 5),
--(184, 'T-5000', 4, 4),
--(185, 'Ameli', 5, 4),
--(186, 'P226', 1, 3),
--(187, 'Ak5', 2, 4),
--(188, 'S.A.T.8', 6, 5),
--(189, 'USAS-12', 6, 4),
--(190, 'NS2000', 6, 3),
--(191, 'M12', 3, 3),
--(192, 'JS05', 4, 5),
--(193, 'T65', 2, 3),
--(194, 'K2', 2, 5),
--(195, 'Gr MG23', 5, 3),
--(196, 'Zas M21', 2, 5),
--(197, 'Carcano M1891', 4, 5),
--(198, 'Carcano M91/38', 4, 5),
--(199, 'Type80', 5, 4),
--(200, 'XM3', 4, 4),
--(201, 'Gepard M1', 4, 3),
--(202, 'Thunder', 1, 4),
--(203, 'Honey Badger', 3, 4),
--(204, 'Ballista', 4, 5),
--(205, 'AN-94', 2, 5),
--(206, 'AK-12', 2, 5),
--(207, 'CZ2000', 2, 4),
--(208, 'HMG21', 5, 5),
--(209, 'OTs-39', 3, 3),
--(210, 'CZ52', 1, 3),
--(211, 'SRS', 4, 5),
--(212, 'K5', 1, 4),
--(213, 'C-MS', 3, 5),
--(214, 'ADS', 2, 5),
--(215, 'MDR', 2, 5),
--(216, 'XM8', 2, 4),
--(217, 'SM-1', 4, 3),
--(218, 'T77', 3, 3),
--(220, 'MP-443', 1, 3),
--(221, 'GSh-18', 1, 3),
--(222, 'TAC-50', 4, 5),
--(223, 'Model L', 2, 3),
--(224, 'PM-06', 3, 5),
--(225, 'Cx4 Storm', 3, 4),
--(226, 'Mk 12', 4, 4),
--(227, 'A-91', 2, 4),
--(228, '100 Shiki', 3, 5),
--(229, 'M870', 6, 5),
--(230, 'OBR', 4, 3),
--(231, 'M82A1', 4, 5),
--(232, 'MP-448', 1, 3),
--(233, 'Px4 Storm', 1, 5),
--(234, 'JS 9', 3, 5),
--(235, 'SPR A3G', 4, 4),
--(236, 'K11', 2, 5),
--(237, 'SAR-21', 2, 4),
--(238, 'QJY-88', 5, 5),
--(239, 'Type 03', 2, 3),
--(240, 'Mk46', 5, 4),
--(241, 'RT-20', 4, 3),
--(242, 'P22', 1, 5),
--(243, '64 Shiki', 2, 5),
--(244, 'TEC-9', 1, 3),
--(245, 'P90', 3, 5),
--(247, 'K31', 4, 4),
--(248, 'Jericho', 1, 4),
--(249, '62 Shiki', 5, 3),
--(250, 'HS2000', 1, 5),
--(251, 'X95', 3, 5),
--(252, 'KSVK', 4, 4),
--(253, 'Lewis', 5, 5),
--(254, 'UKM-2000', 5, 4),
--(255, 'Scout', 4, 3),
--(256, 'Falcon', 4, 3),
--(257, 'M200', 4, 5),
--(258, 'Magal', 2, 3),
--(259, 'PM-9', 3, 5),
--(260, 'PA-15', 1, 5),
--(261, 'QBU-88', 4, 5),
--(262, 'EM-2', 2, 4),
--(263, 'Gr MG36', 5, 5),
--(264, 'Chauchat', 5, 4),
--(265, 'Gr HK33', 2, 3),
--(266, 'R93', 4, 5),
--(267, 'MP41', 3, 3),
--(268, 'T-CMS', 4, 3),
--(269, 'Gr P30', 1, 4),
--(270, '4 Shiki', 4, 4),
--(271, 'K3', 5, 3),
--(272, 'Desert Eagle', 1, 5),
--(273, 'SSG3000', 4, 4),
--(274, 'ACR', 2, 5),
--(275, 'M1895 CB', 5, 4),
--(276, 'Kord', 5, 5),
--(277, 'Gr VP70', 1, 3),
--(278, 'Six12', 6, 3),
--(279, 'INSAS', 2, 3),
--(280, 'MAT-49', 3, 4),
--(281, 'CAWS', 6, 5),
--(282, 'DP-12', 6, 5),
--(283, 'Liberator', 6, 4),
--(284, 'Zas M76', 4, 3),
--(285, 'C-93', 1, 5),
--(286, 'K-PDW', 3, 4),
--(287, 'SIG-556', 2, 5),
--(288, 'CR-21', 2, 4),
--(289, 'R5', 2, 5),
--(290, '89 Shiki', 2, 5),
--(291, '43M', 3, 3),
--(292, 'RPK-16', 5, 5),
--(293, 'AK-15', 2, 5),
--(294, 'Webley', 1, 5),
--(295, 'CF-05', 3, 4),
--(296, 'Gr SL8', 4, 5),
--(297, 'FI M82', 2, 4),
--(298, 'Vepr', 2, 3),
--(299, 'HSM10', 6, 3),
--(300, 'CAR', 5, 3),
--(301, 'MAS-38', 3, 3),
--(302, 'Defender', 6, 4),
--(303, 'HP-35', 1, 5),
--(304, 'SAF', 3, 4),
--(305, 'Tabuk', 4, 4),
--(306, 'AK-Alfa', 2, 5),
--(307, 'ZB-26', 5, 5),
--(308, 'C14', 4, 3),
--(309, 'WKp', 1, 3),
--(310, 'Rex Zero 1', 1, 4),
--(311, 'Lusa', 3, 5),
--(312, 'VSK-94', 4, 5),
--(313, 'S-ACR', 2, 5),
--(314, 'StG-940', 2, 3),
--(315, 'AUG Para', 3, 5),
--(316, 'General Liu', 4, 5),
--(317, 'Mondragon', 4, 4),
--(318, 'VHS', 2, 5),
--(319, 'PM1910', 5, 4),
--(320, 'GM6 Lynx', 4, 3),
--(321, 'TS12', 6, 3),
--(322, 'QSB-91', 1, 3),
--(323, 'LTLX7000', 6, 5),
--(324, 'M6 ASW', 6, 5),
--(325, 'PM5', 6, 4),
--(326, '512', 6, 4),
--(327, 'SUB-2000', 3, 3),
--(328, 'AR-57', 3, 4),
--(329, 'SVCh', 4, 5),
--(330, 'FX-05', 2, 4),
--(331, 'Kolibri', 1, 5),
--(332, 'Derringer', 1, 4),
--(333, 'VP1915', 3, 5),
--(334, 'Savage 99', 4, 5),
--(335, 'Federov', 2, 4),
--(336, 'PPD-40', 3, 4),
--(337, 'De Lisle', 4, 5),
--(338, 'SIG MCX', 2, 5),
--(339, 'RPK-203', 5, 5),
--(340, 'TKB-408', 2, 5),
--(341, 'SP9', 3, 5),
--(342, 'KH2002', 2, 5),
--(343, 'APC556', 2, 4),
--(344, 'FARA 83', 2, 4),
--(345, 'MG338', 5, 5),
--(346, 'CZ 100', 1, 4),
--(347, 'SR-2', 3, 5),
--(348, 'HS.50', 4, 5),
--(349, 'AK-74M', 2, 4),
--(350, 'FO-12', 6, 5),
--(351, 'M26-MASS', 6, 5),
--(352, 'Supernova', 6, 4),
--(353, 'MAG-7', 6, 4),
--(354, 'ZiP .22', 1, 4),
--(355, 'Vigneron M2', 3, 4),
--(356, 'A-545', 2, 5),
--(357, 'Rhino', 1, 5),
--(358, 'PPQ', 1, 4),
--(359, 'Sterling', 3, 5),
--(360, 'TF-Q', 4, 4),
--(361, 'QBZ-191', 2, 5),
--(362, 'LS26', 5, 4),
--(363, 'MPL', 3, 4),
--(364, 'MPK', 3, 4),
--(365, 'SCR', 2, 5),
--(1001, 'Noel', 1, 1),
--(1002, 'Elphelt', 6, 1),
--(1003, 'Kiana', 1, 1),
--(1004, 'Raiden Mei', 4, 1),
--(1005, 'Bronya', 4, 1),
--(1006, 'Theresa', 1, 1),
--(1007, 'Murata Himeko', 2, 1),
--(1008, 'Seele', 6, 1),
--(1009, 'El Clear', 1, 1),
--(1010, 'El Fail', 1, 1),
--(1017, 'Jill Stingray', 1, 1),
--(1018, 'Sei Asagiri', 1, 1),
--(1019, 'Dorothy Haze', 3, 1),
--(1020, 'Stella Hoshii', 4, 1),
--(1021, 'Alma Armas', 5, 1),
--(1022, 'Dana Zane', 6, 1),
--(1023, 'Henrietta', 3, 1),
--(1024, 'Rico', 4, 1),
--(1025, 'Triela', 6, 1),
--(1026, 'Claes', 5, 1),
--(1027, 'Angelica', 2, 1),
--(1028, 'Agent Vector', 3, 1),
--(1029, 'Agent 416', 2, 1),
--(1030, 'Jashin-chan', 3, 1),
--(1031, 'Pekola', 4, 1),
--(1032, 'Medusa', 2, 1),
--(1033, 'Yurine', 5, 1),
--(1034, 'Minos', 6, 1)

--UPDATE Dolls
--SET Image = (
--	SELECT *
--	FROM OPENROWSET(BULK 'D:\Pictures\GFLIndex Images\206.png', SINGLE_BLOB) as image206
--)
--WHERE Id = 206

INSERT INTO DollStats (Health, AmmoConsumption, RationConsumption, Damage, Evasion, Accuracy, RateOfFire, MoveSpeed, Armor, CriticalRate, CriticalDamage, ArmorPenetration, DollId)
VALUES
(40, 10, 10, 12, 9, 6, 31, 15, 0, '20%', '50%', 15, 1)