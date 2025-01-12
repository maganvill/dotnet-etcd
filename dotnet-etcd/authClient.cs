﻿using System;
using System.Threading.Tasks;
using Etcdserverpb;
using Grpc.Core;

namespace dotnet_etcd
{
    public partial class EtcdClient : IDisposable
    {
        public AuthenticateResponse Authenticate(AuthenticateRequest request, Metadata headers = null)
        {
            AuthenticateResponse response = new AuthenticateResponse();
            response = _balancer.GetConnection().authClient.Authenticate(request, headers);
            return response;
        }

        public async Task<AuthenticateResponse> AuthenticateAsync(AuthenticateRequest request, Metadata headers = null)
        {
            AuthenticateResponse response = new AuthenticateResponse();
            response = await _balancer.GetConnection().authClient.AuthenticateAsync(request, headers);
            return response;
        }

        /// <summary>
        /// AuthEnable enables authentication
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthEnableResponse AuthEnable(AuthEnableRequest request, Metadata headers = null)
        {
            AuthEnableResponse response = new AuthEnableResponse();

            response = _balancer.GetConnection().authClient.AuthEnable(request, headers);

            return response;
        }

        /// <summary>
        /// AuthEnableAsync enables authentication in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthEnableResponse> AuthEnableAsync(AuthEnableRequest request, Metadata headers = null)
        {
            AuthEnableResponse response = new AuthEnableResponse();

            response = await _balancer.GetConnection().authClient.AuthEnableAsync(request, headers);

            return response;
        }

        /// <summary>
        /// AuthDisable disables authentication
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthDisableResponse AuthDisable(AuthDisableRequest request, Metadata headers = null)
        {
            AuthDisableResponse response = new AuthDisableResponse();

            response = _balancer.GetConnection().authClient.AuthDisable(request, headers);

            return response;
        }

        /// <summary>
        /// AuthDisableAsync disables authentication in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthDisableResponse> AuthDisableAsync(AuthDisableRequest request, Metadata headers = null)
        {
            AuthDisableResponse response = new AuthDisableResponse();

            response = await _balancer.GetConnection().authClient.AuthDisableAsync(request, headers);

            return response;
        }

        /// <summary>
        /// UserAdd adds a new user
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthUserAddResponse UserAdd(AuthUserAddRequest request, Metadata headers = null)
        {

            AuthUserAddResponse response = new AuthUserAddResponse();

            response = _balancer.GetConnection().authClient.UserAdd(request, headers);

            return response;
        }

        /// <summary>
        /// UserAddAsync adds a new user in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthUserAddResponse> UserAddAsync(AuthUserAddRequest request, Metadata headers = null)
        {

            AuthUserAddResponse response = new AuthUserAddResponse();

            response = await _balancer.GetConnection().authClient.UserAddAsync(request, headers);

            return response;
        }

        /// <summary>
        /// UserGet gets detailed user information
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthUserGetResponse UserGet(AuthUserGetRequest request, Metadata headers = null)
        {
            AuthUserGetResponse response = new AuthUserGetResponse();

            response = _balancer.GetConnection().authClient.UserGet(request, headers);

            return response;
        }

        /// <summary>
        /// UserGetAsync gets detailed user information in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthUserGetResponse> UserGetAsync(AuthUserGetRequest request, Metadata headers = null)
        {
            AuthUserGetResponse response = new AuthUserGetResponse();

            response = await _balancer.GetConnection().authClient.UserGetAsync(request, headers);

            return response;
        }

        /// <summary>
        /// UserList gets a list of all users
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthUserListResponse UserList(AuthUserListRequest request, Metadata headers = null)
        {
            AuthUserListResponse response = new AuthUserListResponse();

            response = _balancer.GetConnection().authClient.UserList(request, headers);


            return response;
        }

        /// <summary>
        /// UserListAsync gets a list of all users in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthUserListResponse> UserListAsync(AuthUserListRequest request, Metadata headers = null)
        {
            AuthUserListResponse response = new AuthUserListResponse();

            response = await _balancer.GetConnection().authClient.UserListAsync(request, headers);

            return response;
        }

        /// <summary>
        /// UserDelete deletes a specified user
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthUserDeleteResponse UserDelete(AuthUserDeleteRequest request, Metadata headers = null)
        {
            AuthUserDeleteResponse response = new AuthUserDeleteResponse();

            response = _balancer.GetConnection().authClient.UserDelete(request, headers);

            return response;
        }

        /// <summary>
        /// UserDeleteAsync deletes a specified user in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthUserDeleteResponse> UserDeleteAsync(AuthUserDeleteRequest request, Metadata headers = null)
        {
            AuthUserDeleteResponse response = new AuthUserDeleteResponse();

            response = await _balancer.GetConnection().authClient.UserDeleteAsync(request, headers);

            return response;
        }

        /// <summary>
        /// UserChangePassword changes the password of a specified user
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthUserChangePasswordResponse UserChangePassword(AuthUserChangePasswordRequest request, Metadata headers = null)
        {
            AuthUserChangePasswordResponse response = new AuthUserChangePasswordResponse();

            response = _balancer.GetConnection().authClient.UserChangePassword(request, headers);

            return response;
        }

        /// <summary>
        /// UserChangePasswordAsync changes the password of a specified user in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthUserChangePasswordResponse> UserChangePasswordAsync(AuthUserChangePasswordRequest request, Metadata headers = null)
        {
            AuthUserChangePasswordResponse response = new AuthUserChangePasswordResponse();

            response = await _balancer.GetConnection().authClient.UserChangePasswordAsync(request, headers);

            return response;
        }

        /// <summary>
        /// UserGrant grants a role to a specified user
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthUserGrantRoleResponse UserGrantRole(AuthUserGrantRoleRequest request, Metadata headers = null)
        {
            AuthUserGrantRoleResponse response = new AuthUserGrantRoleResponse();

            response = _balancer.GetConnection().authClient.UserGrantRole(request, headers);

            return response;
        }

        /// <summary>
        /// UserGrantRoleAsync grants a role to a specified user in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthUserGrantRoleResponse> UserGrantRoleAsync(AuthUserGrantRoleRequest request, Metadata headers = null)
        {
            AuthUserGrantRoleResponse response = new AuthUserGrantRoleResponse();

            response = await _balancer.GetConnection().authClient.UserGrantRoleAsync(request, headers);

            return response;
        }

        /// <summary>
        /// UserRevokeRole revokes a role of specified user
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthUserRevokeRoleResponse UserRevokeRole(AuthUserRevokeRoleRequest request, Metadata headers = null)
        {
            AuthUserRevokeRoleResponse response = new AuthUserRevokeRoleResponse();

            response = _balancer.GetConnection().authClient.UserRevokeRole(request, headers);

            return response;
        }

        /// <summary>
        /// UserRevokeRoleAsync revokes a role of specified user in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthUserRevokeRoleResponse> UserRevokeRoleAsync(AuthUserRevokeRoleRequest request, Metadata headers = null)
        {
            AuthUserRevokeRoleResponse response = new AuthUserRevokeRoleResponse();

            response = await _balancer.GetConnection().authClient.UserRevokeRoleAsync(request, headers);

            return response;
        }

        /// <summary>
        /// RoleAdd adds a new role
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthRoleAddResponse RoleAdd(AuthRoleAddRequest request, Metadata headers = null)
        {
            AuthRoleAddResponse response = new AuthRoleAddResponse();

            response = _balancer.GetConnection().authClient.RoleAdd(request, headers);

            return response;
        }

        /// <summary>
        /// RoleAddAsync adds a new role in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthRoleAddResponse> RoleAddAsync(AuthRoleAddRequest request, Metadata headers = null)
        {
            AuthRoleAddResponse response = new AuthRoleAddResponse();

            response = await _balancer.GetConnection().authClient.RoleAddAsync(request, headers);

            return response;
        }

        /// <summary>
        /// RoleGet gets detailed role information
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthRoleGetResponse RoleGet(AuthRoleGetRequest request, Metadata headers = null)
        {
            AuthRoleGetResponse response = new AuthRoleGetResponse();


            response = _balancer.GetConnection().authClient.RoleGet(request, headers);

            return response;
        }

        /// <summary>
        /// RoleGetASync gets detailed role information in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthRoleGetResponse> RoleGetASync(AuthRoleGetRequest request, Metadata headers = null)
        {
            AuthRoleGetResponse response = new AuthRoleGetResponse();

            response = await _balancer.GetConnection().authClient.RoleGetAsync(request, headers);

            return response;
        }

        /// <summary>
        /// RoleList gets lists of all roles
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthRoleListResponse RoleList(AuthRoleListRequest request, Metadata headers = null)
        {
            AuthRoleListResponse response = new AuthRoleListResponse();

            response = _balancer.GetConnection().authClient.RoleList(request, headers);

            return response;
        }

        /// <summary>
        /// RoleListAsync gets lists of all roles async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthRoleListResponse> RoleListAsync(AuthRoleListRequest request, Metadata headers = null)
        {
            AuthRoleListResponse response = new AuthRoleListResponse();

            response = await _balancer.GetConnection().authClient.RoleListAsync(request, headers);

            return response;
        }

        /// <summary>
        /// RoleDelete deletes a specified role
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthRoleDeleteResponse RoleDelete(AuthRoleDeleteRequest request, Metadata headers = null)
        {
            AuthRoleDeleteResponse response = new AuthRoleDeleteResponse();

            response = _balancer.GetConnection().authClient.RoleDelete(request, headers);

            return response;
        }

        /// <summary>
        /// RoleDeleteAsync deletes a specified role in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthRoleDeleteResponse> RoleDeleteAsync(AuthRoleDeleteRequest request, Metadata headers = null)
        {
            AuthRoleDeleteResponse response = new AuthRoleDeleteResponse();

            response = await _balancer.GetConnection().authClient.RoleDeleteAsync(request, headers);

            return response;
        }

        /// <summary>
        /// RoleGrantPermission grants a permission of a specified key or range to a specified role
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthRoleGrantPermissionResponse RoleGrantPermission(AuthRoleGrantPermissionRequest request, Metadata headers = null)
        {
            AuthRoleGrantPermissionResponse response = new AuthRoleGrantPermissionResponse();

            response = _balancer.GetConnection().authClient.RoleGrantPermission(request, headers);

            return response;
        }

        /// <summary>
        /// RoleGrantPermissionAsync grants a permission of a specified key or range to a specified role in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthRoleGrantPermissionResponse> RoleGrantPermissionAsync(AuthRoleGrantPermissionRequest request, Metadata headers = null)
        {
            AuthRoleGrantPermissionResponse response = new AuthRoleGrantPermissionResponse();

            response = await _balancer.GetConnection().authClient.RoleGrantPermissionAsync(request, headers);

            return response;
        }

        /// <summary>
        /// RoleRevokePermission revokes a key or range permission of a specified role
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AuthRoleRevokePermissionResponse RoleRevokePermission(AuthRoleRevokePermissionRequest request, Metadata headers = null)
        {
            AuthRoleRevokePermissionResponse response = new AuthRoleRevokePermissionResponse();

            response = _balancer.GetConnection().authClient.RoleRevokePermission(request, headers);

            return response;
        }

        /// <summary>
        /// RoleRevokePermissionAsync revokes a key or range permission of a specified role in async
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AuthRoleRevokePermissionResponse> RoleRevokePermissionAsync(AuthRoleRevokePermissionRequest request, Metadata headers = null)
        {
            AuthRoleRevokePermissionResponse response = new AuthRoleRevokePermissionResponse();

            response = await _balancer.GetConnection().authClient.RoleRevokePermissionAsync(request, headers);

            return response;
        }
    }
}
