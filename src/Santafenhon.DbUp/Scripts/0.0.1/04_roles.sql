
--ADD ROLES
INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp) VALUES('d3fc0676-f84b-4b74-86f7-7caf0a557141', 'SysAdmin', 'SYSADMIN', '65d98bb2-2177-47e8-9217-5b23df7e328d');
INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp) VALUES('9278444d-7465-41c7-aaba-671ed4ca886e', 'Superuser', 'SUPERUSER', '01bf0d29-7a1d-4109-9148-4446729b2033');
INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp) VALUES('3ebe9cff-b312-479c-83de-27a73c84aeac', 'Webuser', 'WEBUSER', 'b89236e9-06f8-4a9b-8085-54bd0f5dd407');




--ADD PIRANHACMS ROLE CLAIMS
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(1, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'LanguageDelete', 'LanguageDelete');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(2, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaModules', 'PiranhaModules');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(3, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPagePreview', 'PiranhaPagePreview');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(4, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPages', 'PiranhaPages');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(5, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPagesAdd', 'PiranhaPagesAdd');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(6, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPagesDelete', 'PiranhaPagesDelete');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(7, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPagesEdit', 'PiranhaPagesEdit');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(8, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPagesPublish', 'PiranhaPagesPublish');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(9, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPagesSave', 'PiranhaPagesSave');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(10, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaMediaEdit', 'PiranhaMediaEdit');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(11, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPostPreview', 'PiranhaPostPreview');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(12, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPostsAdd', 'PiranhaPostsAdd');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(13, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPostsDelete', 'PiranhaPostsDelete');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(14, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPostsEdit', 'PiranhaPostsEdit');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(15, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPostsPublish', 'PiranhaPostsPublish');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(16, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPostsSave', 'PiranhaPostsSave');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(17, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaSites', 'PiranhaSites');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(18, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaSitesAdd', 'PiranhaSitesAdd');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(19, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaSitesDelete', 'PiranhaSitesDelete');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(20, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaPosts', 'PiranhaPosts');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(21, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaMediaDeleteFolder', 'PiranhaMediaDeleteFolder');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(22, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaMediaDelete', 'PiranhaMediaDelete');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(23, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaMediaAddFolder', 'PiranhaMediaAddFolder');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(24, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'LanguageAdd', 'LanguageAdd');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(25, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'Language', 'Language');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(26, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'LanguageEdit', 'LanguageEdit');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(27, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaAdmin', 'PiranhaAdmin');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(28, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaAliases', 'PiranhaAliases');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(29, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaAliasesDelete', 'PiranhaAliasesDelete');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(30, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaAliasesEdit', 'PiranhaAliasesEdit');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(31, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaComments', 'PiranhaComments');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(32, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaCommentsApprove', 'PiranhaCommentsApprove');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(33, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaCommentsDelete', 'PiranhaCommentsDelete');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(34, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaConfig', 'PiranhaConfig');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(35, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaConfigEdit', 'PiranhaConfigEdit');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(36, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaContent', 'PiranhaContent');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(37, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaContentAdd', 'PiranhaContentAdd');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(38, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaContentDelete', 'PiranhaContentDelete');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(39, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaContentEdit', 'PiranhaContentEdit');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(40, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaContentSave', 'PiranhaContentSave');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(41, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaMedia', 'PiranhaMedia');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(42, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaMediaAdd', 'PiranhaMediaAdd');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(43, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaSitesEdit', 'PiranhaSitesEdit');
INSERT INTO AspNetRoleClaims (Id, RoleId, ClaimType, ClaimValue) VALUES(44, 'd3fc0676-f84b-4b74-86f7-7caf0a557141', 'PiranhaSitesSave', 'PiranhaSitesSave');




--ADD USER
INSERT INTO AspNetUsers (Id, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount) VALUES('29d508d3-b6a9-46b8-920f-803ce6819062', 'jfaquinojr@outlook.com', 'JFAQUINOJR@OUTLOOK.COM', 'jfaquinojr@outlook.com', 'JFAQUINOJR@OUTLOOK.COM', 1, 'AQAAAAEAACcQAAAAEPjtITyBI3sTFOdMJuVU/wQzb6nHMcP5TLFrOWuJ2j67E/MBXDraU6rKxbDaE5q33g==', '6c022f4b-51e7-48e5-bd49-fd11bdc91e67', '237bac61-e4f3-4d8e-ac1b-632405ac20f7', '+111111111111', 1, 0, NULL, 0, 0);






--SET USER ROLE
INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES('29d508d3-b6a9-46b8-920f-803ce6819062', 'd3fc0676-f84b-4b74-86f7-7caf0a557141');
INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES('29d508d3-b6a9-46b8-920f-803ce6819062', '9278444d-7465-41c7-aaba-671ed4ca886e');
INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES('29d508d3-b6a9-46b8-920f-803ce6819062', '3ebe9cff-b312-479c-83de-27a73c84aeac');
