INSERT INTO AspNetUsers(Id, UserName, NormalizedUsername, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled, AccessFailedCount)
SELECT
'97f1e3fc-7199-4a98-80c5-7428c0acb3ca' Id,
'jfaquinojr@gmail.com' UserName,
'jfaquinojr@gmail.com' NormalizedUsername,
'jfaquinojr@gmail.com' Email,
'jfaquinojr@gmail.com' NormalizedEmail,
1 EmailConfirmed,
'AQAAAAEAACcQAAAAEBZL/UnURCOqx+IWX5d3ewlXK4alBBEekJUEtQ+Nx39spBOeYJ8N89MvkExGidm3jA==' PasswordHash,
'DFZLHY6GQSKGBE5O35HCQVZPHMZEHZEL' SecurityStamp,
'4181d7a3-3274-4094-9138-397ee6f5ed28' ConcurrencyStamp,
0 PhoneNumberConfirmed,
0 TwoFactorEnabled,
0 LockoutEnabled,
0 AccessFailedCount;



INSERT INTO AspNetRoles(Id, Name, NormalizedName, ConcurrencyStamp)
SELECT
'2c8a0863-f1be-4e98-ab2c-e885f0a3bd49' Id,
'Admin' Name,
'ADMIN' NormalizedName,
'1df06529-1d95-4aa9-99df-761e5e1d2214' ConcurrencyStamp;



INSERT INTO AspNetUserRoles(UserId, RoleId)
SELECT '97f1e3fc-7199-4a98-80c5-7428c0acb3ca', '2c8a0863-f1be-4e98-ab2c-e885f0a3bd49';


