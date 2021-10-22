IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('table_home_address'))
BEGIN;
    DROP TABLE [table_home_address];
END;
GO

CREATE TABLE [table_home_address] (
    [table_home_addressID] INTEGER NOT NULL IDENTITY(1, 1),
    [address] VARCHAR(255) NULL,
    PRIMARY KEY ([table_home_addressID])
);
GO

INSERT INTO [table_home_address] (address)
VALUES
  ('4712 Morbi Avenue'),
  ('Ap #774-3180 Leo Avenue'),
  ('Ap #164-629 Enim Ave'),
  ('Ap #923-380 Sociis St.'),
  ('695-9701 Est Avenue'),
  ('672-3566 Urna St.'),
  ('P.O. Box 765, 9766 Auctor Av.'),
  ('P.O. Box 763, 292 Odio Rd.'),
  ('Ap #247-4125 Ad Rd.'),
  ('2124 Et Road');
INSERT INTO [table_home_address] (address)
VALUES
  ('334-4518 Consectetuer, Rd.'),
  ('P.O. Box 381, 5408 Arcu. Ave'),
  ('Ap #702-2867 Lobortis Rd.'),
  ('221-4703 Porttitor Rd.'),
  ('199-2909 Iaculis Road'),
  ('4645 Iaculis Street'),
  ('Ap #234-289 Vivamus Avenue'),
  ('1446 Dui. Road'),
  ('875-5657 Vitae, Ave'),
  ('Ap #818-6719 Posuere, St.');
INSERT INTO [table_home_address] (address)
VALUES
  ('P.O. Box 542, 5016 Quisque St.'),
  ('677-306 Sollicitudin Avenue'),
  ('Ap #967-2259 Nisl Rd.'),
  ('Ap #862-7592 Tempus, Road'),
  ('Ap #389-8254 Felis. Ave'),
  ('158-3688 Eget, Av.'),
  ('Ap #393-6019 Tincidunt St.'),
  ('3006 A Rd.'),
  ('249-5288 Tempor Road'),
  ('573-6580 Aliquet Street');
INSERT INTO [table_home_address] (address)
VALUES
  ('6697 Molestie. Ave'),
  ('593-6469 Neque Street'),
  ('725-5542 Blandit Av.'),
  ('540-8238 Sollicitudin Street'),
  ('Ap #159-2634 Et Rd.'),
  ('Ap #878-6326 Erat, Av.'),
  ('Ap #883-1016 Urna. Avenue'),
  ('7424 Curae Ave'),
  ('Ap #664-4815 Erat St.'),
  ('P.O. Box 874, 7129 Nullam Avenue');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #431-8768 In, Avenue'),
  ('202-7845 Hymenaeos. St.'),
  ('9579 Cursus Rd.'),
  ('628-5225 Nullam Rd.'),
  ('P.O. Box 901, 5782 Ut Road'),
  ('964-1782 Eu, Rd.'),
  ('P.O. Box 665, 8762 Pede, Rd.'),
  ('Ap #311-1644 Aliquam Road'),
  ('P.O. Box 911, 3392 Eu St.'),
  ('P.O. Box 924, 8510 Sed, Ave');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #647-287 Non, Av.'),
  ('9166 Amet Av.'),
  ('460-4669 Eu, Rd.'),
  ('4359 Adipiscing St.'),
  ('Ap #177-4492 Consectetuer Avenue'),
  ('667-2873 Cubilia Avenue'),
  ('2423 Lorem Rd.'),
  ('P.O. Box 117, 7076 Donec Rd.'),
  ('9713 Imperdiet, Ave'),
  ('193-1974 Imperdiet Rd.');
INSERT INTO [table_home_address] (address)
VALUES
  ('P.O. Box 213, 6095 Aliquet, Road'),
  ('Ap #981-1235 Eu Ave'),
  ('9509 Risus Road'),
  ('496-3236 Dictum Rd.'),
  ('Ap #218-7608 Magna. Rd.'),
  ('748-6232 Fringilla Rd.'),
  ('Ap #578-7116 Eros. Rd.'),
  ('Ap #124-2727 Eget Rd.'),
  ('210-9948 Amet St.'),
  ('2630 Eleifend Road');
INSERT INTO [table_home_address] (address)
VALUES
  ('531-4947 Neque Av.'),
  ('P.O. Box 913, 8977 Lorem Rd.'),
  ('P.O. Box 774, 3691 Gravida Rd.'),
  ('8936 Venenatis Ave'),
  ('264-7383 Est. Ave'),
  ('Ap #662-5389 Laoreet St.'),
  ('Ap #686-1601 Quis Rd.'),
  ('P.O. Box 201, 308 Nec, Av.'),
  ('4496 Nisi Street'),
  ('684-3691 Mauris St.');
INSERT INTO [table_home_address] (address)
VALUES
  ('162-7332 Vulputate St.'),
  ('445-2875 Sapien Av.'),
  ('1527 Porta Street'),
  ('Ap #287-8235 Auctor, Av.'),
  ('869 Arcu Av.'),
  ('5749 Egestas, St.'),
  ('651-3171 Ante Rd.'),
  ('555-1133 Sed Av.'),
  ('Ap #450-4175 Ipsum. Rd.'),
  ('P.O. Box 586, 877 Sed, Avenue');
INSERT INTO [table_home_address] (address)
VALUES
  ('P.O. Box 612, 5097 Nonummy Ave'),
  ('P.O. Box 749, 4151 Nulla Ave'),
  ('3273 Gravida. Ave'),
  ('P.O. Box 905, 7166 Posuere St.'),
  ('1463 Erat Ave'),
  ('752-5886 Aliquam Road'),
  ('Ap #967-1588 Ipsum St.'),
  ('287-2601 Eleifend St.'),
  ('Ap #710-4552 Est Rd.'),
  ('3375 Ante Av.');
INSERT INTO [table_home_address] (address)
VALUES
  ('760-7511 Eu Rd.'),
  ('768-8904 Euismod Rd.'),
  ('650-8805 Phasellus Road'),
  ('Ap #627-5471 Lorem, Ave'),
  ('Ap #602-7279 Pellentesque St.'),
  ('Ap #364-6531 Tristique Rd.'),
  ('P.O. Box 149, 3382 Malesuada Street'),
  ('P.O. Box 848, 8854 Dolor, Rd.'),
  ('P.O. Box 337, 3072 Magna. St.'),
  ('Ap #993-7173 Vestibulum. Av.');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #617-4334 Sem Street'),
  ('506-8564 Aliquet Street'),
  ('898-1262 Pede Ave'),
  ('124-8197 Facilisis St.'),
  ('590-570 Curabitur Rd.'),
  ('P.O. Box 432, 1620 Mi Ave'),
  ('Ap #207-1858 Convallis Rd.'),
  ('606-6158 Vehicula St.'),
  ('1725 Cras Avenue'),
  ('P.O. Box 392, 3730 Adipiscing Road');
INSERT INTO [table_home_address] (address)
VALUES
  ('919-3671 Nunc Ave'),
  ('P.O. Box 983, 3780 Cursus Rd.'),
  ('Ap #516-5837 Mattis Avenue'),
  ('826-2513 Luctus, Rd.'),
  ('Ap #755-2997 Sed St.'),
  ('Ap #370-1070 Mauris, St.'),
  ('298-571 Arcu. Rd.'),
  ('P.O. Box 177, 8022 Donec St.'),
  ('P.O. Box 725, 5059 Dui. St.'),
  ('172-7189 Velit. Road');
INSERT INTO [table_home_address] (address)
VALUES
  ('304-5274 Risus. Rd.'),
  ('736-7111 Sodales Av.'),
  ('Ap #457-595 Velit Rd.'),
  ('Ap #210-4990 Tortor St.'),
  ('Ap #881-3053 Gravida St.'),
  ('604-6791 Mauris St.'),
  ('Ap #900-6539 Turpis. St.'),
  ('Ap #376-1788 Curabitur Street'),
  ('Ap #171-6827 In Rd.'),
  ('Ap #213-487 Vitae, Av.');
INSERT INTO [table_home_address] (address)
VALUES
  ('651-4395 Ut Street'),
  ('7283 Sodales Rd.'),
  ('819-2293 Proin Road'),
  ('3208 Faucibus Avenue'),
  ('Ap #316-4576 Magnis St.'),
  ('P.O. Box 981, 3653 Etiam St.'),
  ('Ap #153-9931 At Av.'),
  ('204-1507 Augue Rd.'),
  ('Ap #165-6957 Semper Rd.'),
  ('127-7103 Eget, St.');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #356-6937 Nullam St.'),
  ('1682 Blandit Street'),
  ('Ap #453-871 Malesuada Avenue'),
  ('456-8205 Nec St.'),
  ('220-700 Volutpat. Rd.'),
  ('P.O. Box 286, 5062 Donec Rd.'),
  ('Ap #950-5657 Penatibus St.'),
  ('8964 Felis. Rd.'),
  ('850-8901 Torquent Road'),
  ('698-6781 Auctor Avenue');
INSERT INTO [table_home_address] (address)
VALUES
  ('397-1629 In Ave'),
  ('P.O. Box 664, 9367 Malesuada Rd.'),
  ('669-1653 Tincidunt Rd.'),
  ('3186 Eros Road'),
  ('P.O. Box 283, 5913 Feugiat Av.'),
  ('Ap #195-406 Porttitor Rd.'),
  ('708-3832 Et, Rd.'),
  ('Ap #541-3837 Natoque Street'),
  ('Ap #876-8361 Nec St.'),
  ('714-487 Phasellus Road');
INSERT INTO [table_home_address] (address)
VALUES
  ('P.O. Box 717, 4979 Odio. Ave'),
  ('760-4595 Pellentesque Rd.'),
  ('270-1075 Ac, Street'),
  ('378-1438 Quis St.'),
  ('438-391 Nullam Avenue'),
  ('Ap #975-9448 Ridiculus Road'),
  ('P.O. Box 346, 8787 Proin Rd.'),
  ('6879 Ipsum Road'),
  ('112-6722 Aenean Rd.'),
  ('Ap #657-5258 Fermentum Av.');
INSERT INTO [table_home_address] (address)
VALUES
  ('8033 Bibendum Av.'),
  ('Ap #895-3100 Mus. Rd.'),
  ('Ap #373-1698 Tellus Rd.'),
  ('P.O. Box 214, 2595 Integer Av.'),
  ('P.O. Box 786, 2646 Est Rd.'),
  ('Ap #925-4152 Mi Rd.'),
  ('P.O. Box 704, 9250 Cursus St.'),
  ('860-4595 Ornare, Avenue'),
  ('386-8989 Fermentum Road'),
  ('P.O. Box 252, 9813 Magna. St.');
INSERT INTO [table_home_address] (address)
VALUES
  ('P.O. Box 593, 5996 Cras Av.'),
  ('Ap #657-5553 Ipsum. Road'),
  ('Ap #125-7000 Aliquam Av.'),
  ('Ap #275-8883 Consequat St.'),
  ('132-9835 Odio Av.'),
  ('P.O. Box 527, 1925 Aliquam Avenue'),
  ('P.O. Box 927, 8553 Fusce Rd.'),
  ('P.O. Box 626, 4605 Sit Rd.'),
  ('Ap #590-730 Eu, Avenue'),
  ('9694 Fermentum St.');
INSERT INTO [table_home_address] (address)
VALUES
  ('P.O. Box 110, 7964 Ut, Av.'),
  ('2071 Morbi Rd.'),
  ('Ap #756-4633 Cursus Avenue'),
  ('Ap #711-8776 Mauris Rd.'),
  ('146-5663 Sagittis. St.'),
  ('P.O. Box 121, 6457 Lacus. Ave'),
  ('P.O. Box 816, 8070 Et Road'),
  ('Ap #715-8731 Amet Rd.'),
  ('P.O. Box 791, 9959 Dolor Rd.'),
  ('Ap #903-4350 Nibh. Av.');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #698-9657 Risus, Rd.'),
  ('7270 Senectus Ave'),
  ('2526 Semper Road'),
  ('Ap #468-1333 Cursus. Rd.'),
  ('Ap #654-3179 Dignissim. Rd.'),
  ('1449 Pede. Street'),
  ('P.O. Box 991, 9061 Purus. Av.'),
  ('Ap #404-569 Diam Road'),
  ('Ap #498-3877 Nunc St.'),
  ('Ap #356-5101 Mauris, St.');
INSERT INTO [table_home_address] (address)
VALUES
  ('1042 Vivamus St.'),
  ('170-1913 Nisi St.'),
  ('115-2278 Vestibulum St.'),
  ('829-4477 Senectus Av.'),
  ('616 Cursus St.'),
  ('Ap #580-1988 Eros. Av.'),
  ('4359 Euismod Avenue'),
  ('139-8207 Adipiscing. Av.'),
  ('Ap #406-1232 Nec Rd.'),
  ('716-8795 Non, Street');
INSERT INTO [table_home_address] (address)
VALUES
  ('245-1088 Nascetur Rd.'),
  ('648-1884 Dapibus Rd.'),
  ('742-3514 Nam Avenue'),
  ('Ap #827-7041 Vel, Street'),
  ('569-4970 Vel St.'),
  ('Ap #940-7174 Quis Rd.'),
  ('8364 Quisque St.'),
  ('Ap #191-3814 Nullam Street'),
  ('2746 Venenatis St.'),
  ('P.O. Box 500, 3259 Enim. Ave');
INSERT INTO [table_home_address] (address)
VALUES
  ('P.O. Box 940, 2713 Nisl. Ave'),
  ('123-2300 Nunc Rd.'),
  ('P.O. Box 644, 4192 Aliquam Ave'),
  ('P.O. Box 505, 6814 Lacus. Rd.'),
  ('Ap #407-613 Vel Road'),
  ('Ap #849-733 Lorem Street'),
  ('Ap #326-5206 Lacus. Rd.'),
  ('1787 Eget, Av.'),
  ('Ap #144-5862 Sollicitudin Av.'),
  ('Ap #811-161 Mauris St.');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #615-8667 Eu St.'),
  ('868-9297 Eu Rd.'),
  ('Ap #736-1872 In Avenue'),
  ('970-9892 Scelerisque Rd.'),
  ('Ap #856-6080 Lacus. Ave'),
  ('504-4705 Orci Ave'),
  ('6984 In Rd.'),
  ('515-2122 Tristique St.'),
  ('Ap #356-6189 Sit Ave'),
  ('Ap #329-8864 Magna Rd.');
INSERT INTO [table_home_address] (address)
VALUES
  ('409-9471 Cras St.'),
  ('Ap #876-8431 Nulla Ave'),
  ('436-1815 Pulvinar Ave'),
  ('P.O. Box 488, 9609 Nascetur St.'),
  ('517-8800 Ante Street'),
  ('Ap #211-9053 Fames Rd.'),
  ('P.O. Box 710, 9167 Condimentum. St.'),
  ('Ap #338-8208 Nonummy Rd.'),
  ('703-765 Neque. Av.'),
  ('Ap #203-8811 Non, Avenue');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #993-6932 Velit. Ave'),
  ('940-7924 Consequat Av.'),
  ('723-8662 Per St.'),
  ('Ap #860-3584 In Rd.'),
  ('827 Magna. St.'),
  ('322-2589 Et, Avenue'),
  ('858-4483 Placerat, St.'),
  ('Ap #706-9757 Rutrum Av.'),
  ('Ap #319-3599 Donec Rd.'),
  ('Ap #743-7011 Ut Ave');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #974-8347 Ornare. St.'),
  ('153-7939 Vel Avenue'),
  ('Ap #653-9085 A, Road'),
  ('741-803 Parturient Street'),
  ('P.O. Box 241, 1579 Aenean Ave'),
  ('P.O. Box 723, 9357 Vel Rd.'),
  ('817-2631 Sollicitudin Av.'),
  ('413-429 Sed St.'),
  ('2343 Adipiscing Av.'),
  ('141-4555 Primis St.');
INSERT INTO [table_home_address] (address)
VALUES
  ('248-5773 Gravida Ave'),
  ('Ap #142-5966 Risus Avenue'),
  ('Ap #319-9589 Lacus. Road'),
  ('Ap #936-2657 Nonummy Ave'),
  ('515-8444 Nullam Road'),
  ('Ap #382-8786 Fusce Road'),
  ('Ap #158-7573 Vehicula Street'),
  ('Ap #430-5093 Nascetur Street'),
  ('600-7893 Ac, Ave'),
  ('Ap #264-3176 Proin Rd.');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #299-5966 Magna. Street'),
  ('Ap #846-376 Nulla. Rd.'),
  ('Ap #965-5337 Ut St.'),
  ('Ap #332-4698 Dui. Ave'),
  ('Ap #366-5192 Sodales Avenue'),
  ('P.O. Box 948, 805 Sed Ave'),
  ('Ap #356-9591 Libero St.'),
  ('156-2310 Pede Ave'),
  ('323-6452 Tellus. Road'),
  ('P.O. Box 827, 6608 Tempor Road');
INSERT INTO [table_home_address] (address)
VALUES
  ('545-5692 Interdum. St.'),
  ('P.O. Box 536, 117 Est. Road'),
  ('Ap #737-8825 Malesuada Street'),
  ('Ap #843-346 Gravida. Av.'),
  ('916-1328 Sagittis Ave'),
  ('P.O. Box 843, 7356 Posuere Street'),
  ('138-7913 Tincidunt Road'),
  ('P.O. Box 757, 1031 Curabitur Rd.'),
  ('Ap #817-182 Pellentesque Av.'),
  ('1785 Eu Street');
INSERT INTO [table_home_address] (address)
VALUES
  ('927-852 Sed Av.'),
  ('384-1072 Nam Ave'),
  ('Ap #468-5283 Dictum Road'),
  ('7675 Aliquam Street'),
  ('237-9166 Ut St.'),
  ('635-6172 Nullam Rd.'),
  ('330-7412 Mauris Av.'),
  ('P.O. Box 353, 3383 Id Avenue'),
  ('Ap #928-1889 Lacinia Ave'),
  ('Ap #477-8730 Lectus Street');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #580-2336 In Ave'),
  ('891-3792 In Road'),
  ('Ap #966-6704 Enim, Ave'),
  ('411-7463 Eros Road'),
  ('673-6957 Ac Avenue'),
  ('832-1229 Sociosqu Rd.'),
  ('P.O. Box 986, 8113 In Avenue'),
  ('Ap #811-5559 Ornare, St.'),
  ('489-9066 Lacus. Av.'),
  ('Ap #602-589 Sem Street');
INSERT INTO [table_home_address] (address)
VALUES
  ('528-7122 Gravida Street'),
  ('1808 Ac Road'),
  ('5597 Ipsum Avenue'),
  ('P.O. Box 851, 6700 Odio Av.'),
  ('184-9092 Nec, Rd.'),
  ('P.O. Box 752, 7140 In Street'),
  ('Ap #607-4577 Porttitor Road'),
  ('188-1900 Velit St.'),
  ('P.O. Box 263, 3590 Quam. Street'),
  ('4972 Felis Rd.');
INSERT INTO [table_home_address] (address)
VALUES
  ('159-2196 Lorem Av.'),
  ('Ap #617-1649 Eros St.'),
  ('Ap #524-2794 Odio. Street'),
  ('5362 Quisque St.'),
  ('Ap #412-3738 Diam Rd.'),
  ('273-3190 Dignissim St.'),
  ('Ap #891-8167 Luctus Rd.'),
  ('854 Cras Ave'),
  ('663-8430 Posuere St.'),
  ('433-4982 Rhoncus St.');
INSERT INTO [table_home_address] (address)
VALUES
  ('P.O. Box 200, 4259 Eu Rd.'),
  ('Ap #409-1482 Velit. Rd.'),
  ('6053 Lacus. Rd.'),
  ('Ap #270-8254 Posuere Avenue'),
  ('P.O. Box 312, 6756 Proin Ave'),
  ('P.O. Box 688, 4401 Eget, Ave'),
  ('P.O. Box 196, 5811 Et Avenue'),
  ('300-8516 Amet Rd.'),
  ('Ap #632-9460 Integer St.'),
  ('Ap #744-3508 Facilisis Ave');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #524-8787 Duis Road'),
  ('Ap #710-9986 Nunc Avenue'),
  ('Ap #882-6505 Dapibus Avenue'),
  ('475 Ut Rd.'),
  ('584-2387 Sed Rd.'),
  ('311-3404 Dui. Av.'),
  ('Ap #109-5535 Rhoncus. Rd.'),
  ('Ap #905-5484 Non Rd.'),
  ('596-3524 Morbi St.'),
  ('839-7012 Dolor Street');
INSERT INTO [table_home_address] (address)
VALUES
  ('P.O. Box 921, 9812 Ridiculus St.'),
  ('3088 Lacus. Street'),
  ('487-5969 Mauris Av.'),
  ('9249 Nisi. Av.'),
  ('554-2940 Mauris, Av.'),
  ('Ap #115-606 Nunc St.'),
  ('794-5295 Adipiscing Rd.'),
  ('3083 Tellus Street'),
  ('P.O. Box 884, 2428 Non, Rd.'),
  ('221-5335 Morbi Ave');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #450-6674 Metus St.'),
  ('872-4818 Erat. St.'),
  ('5548 A St.'),
  ('5191 Nulla St.'),
  ('382-7980 Arcu. Rd.'),
  ('932-4805 Mauris Rd.'),
  ('819-1664 Elementum, Ave'),
  ('8069 Ipsum. Road'),
  ('Ap #671-1312 Quis Rd.'),
  ('913-7357 Donec Rd.');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #529-547 Vel Road'),
  ('237-3504 Fringilla St.'),
  ('297-3937 Ligula Rd.'),
  ('682-6526 Mi St.'),
  ('3636 Vivamus St.'),
  ('P.O. Box 349, 989 Nunc Street'),
  ('938-5201 A Ave'),
  ('470-4730 Nec Avenue'),
  ('641-1892 Fusce Street'),
  ('708-3011 Euismod Av.');
INSERT INTO [table_home_address] (address)
VALUES
  ('P.O. Box 889, 9202 Eu St.'),
  ('356-6390 Porttitor Road'),
  ('Ap #894-3114 Quisque Street'),
  ('Ap #568-1035 A, Ave'),
  ('Ap #302-4943 Interdum. Avenue'),
  ('2092 Vel St.'),
  ('P.O. Box 325, 7621 Nunc. Rd.'),
  ('2999 Facilisis Ave'),
  ('492-2561 Adipiscing Rd.'),
  ('5638 Leo. Avenue');
INSERT INTO [table_home_address] (address)
VALUES
  ('P.O. Box 774, 2277 Elit Rd.'),
  ('302-7143 Maecenas Avenue'),
  ('Ap #776-6297 Tempor Rd.'),
  ('Ap #956-2851 Aliquam Av.'),
  ('290-792 Ut St.'),
  ('Ap #598-1322 Dictum St.'),
  ('1786 Interdum. Av.'),
  ('4681 Ipsum Av.'),
  ('193-3176 Quisque Road'),
  ('1729 Ipsum Av.');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #462-998 Interdum. St.'),
  ('P.O. Box 474, 5946 A, St.'),
  ('Ap #207-3925 Hendrerit St.'),
  ('Ap #729-7793 Sem. Rd.'),
  ('P.O. Box 744, 8976 Consectetuer Rd.'),
  ('403-1720 Arcu St.'),
  ('Ap #246-4460 Sit Street'),
  ('P.O. Box 777, 4411 Etiam St.'),
  ('182-1440 Libero Av.'),
  ('921-7482 Semper Avenue');
INSERT INTO [table_home_address] (address)
VALUES
  ('6047 Libero St.'),
  ('5577 Placerat, Road'),
  ('P.O. Box 414, 6409 Facilisis Rd.'),
  ('Ap #513-1738 Etiam Av.'),
  ('425-6580 Molestie Street'),
  ('451-1892 Non, Rd.'),
  ('832-5432 Massa. Rd.'),
  ('302-2660 Sem, Road'),
  ('Ap #431-1359 Est. Avenue'),
  ('Ap #204-5216 Odio Rd.');
INSERT INTO [table_home_address] (address)
VALUES
  ('790-6170 Ornare Ave'),
  ('214-5520 Phasellus Rd.'),
  ('Ap #554-8234 Cras Rd.'),
  ('P.O. Box 335, 2387 Dolor. St.'),
  ('908-2246 Interdum Rd.'),
  ('440-528 Lacus. St.'),
  ('6871 Erat, Rd.'),
  ('Ap #182-8436 Non Avenue'),
  ('297-8464 Vitae Road'),
  ('679-3565 Ac Ave');
INSERT INTO [table_home_address] (address)
VALUES
  ('967-7438 Magna. St.'),
  ('Ap #131-436 Taciti Road'),
  ('2190 Eros Street'),
  ('3726 Non Avenue'),
  ('Ap #172-3857 Tortor. Rd.'),
  ('2728 Pede. Street'),
  ('9686 Risus. Rd.'),
  ('756-3705 Curabitur Street'),
  ('803-8541 In St.'),
  ('Ap #112-4989 In, Road');
INSERT INTO [table_home_address] (address)
VALUES
  ('P.O. Box 747, 9434 Varius Rd.'),
  ('383-1888 Pede. Road'),
  ('9873 Lacus. Ave'),
  ('366-5844 Nec Street'),
  ('417-4553 Tempus Road'),
  ('Ap #956-7188 Senectus Av.'),
  ('Ap #114-666 Sit Av.'),
  ('P.O. Box 662, 6704 Vulputate Street'),
  ('Ap #540-9491 Mollis Street'),
  ('Ap #939-1118 Augue Avenue');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #786-648 Eros. Ave'),
  ('P.O. Box 983, 1151 Sollicitudin Rd.'),
  ('585-8030 Pede. Ave'),
  ('688-6817 Sociis St.'),
  ('Ap #157-4457 Neque Rd.'),
  ('Ap #480-2062 Egestas. Street'),
  ('P.O. Box 414, 9516 Nunc Av.'),
  ('P.O. Box 287, 6537 Sit Ave'),
  ('156-1289 Euismod Av.'),
  ('P.O. Box 935, 637 Pede. St.');
INSERT INTO [table_home_address] (address)
VALUES
  ('Ap #508-1532 Torquent Av.'),
  ('Ap #567-2877 Semper, Road'),
  ('579-5465 Tellus Avenue'),
  ('Ap #266-6186 Imperdiet Avenue'),
  ('658 Mattis Road'),
  ('P.O. Box 597, 3034 Erat, Avenue'),
  ('P.O. Box 232, 8167 Vel Avenue'),
  ('906-2133 Suspendisse Street'),
  ('793-7166 Imperdiet Rd.'),
  ('773-2283 Vitae, Avenue');
