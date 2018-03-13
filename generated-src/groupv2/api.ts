/**
 * Bungie.Net API
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * OpenAPI spec version: 2.1.4
 * Contact: support@bungie.com
 *
 * NOTE: This class is auto generated by the bungie-api-ts code generator program.
 * https://github.com/DestinyItemManager/bugie-api-ts
 * Do not edit these files manually.
 */

import { HttpClient } from '../http';

import {
  BungieMembershipType,
  ServerResponse
} from '../common';
import {
  ClanBanner,
  EntityActionResult,
  GroupAction,
  GroupApplicationListRequest,
  GroupApplicationRequest,
  GroupApplicationResponse,
  GroupBanRequest,
  GroupCreationResponse,
  GroupDateRange,
  GroupEditAction,
  GroupMemberLeaveResult,
  GroupMembershipSearchResponse,
  GroupOptionalConversation,
  GroupOptionalConversationAddRequest,
  GroupOptionalConversationEditRequest,
  GroupOptionsEditAction,
  GroupPotentialMemberStatus,
  GroupPotentialMembershipSearchResponse,
  GroupQuery,
  GroupResponse,
  GroupSearchResponse,
  GroupTheme,
  GroupType,
  GroupV2Card,
  GroupsForMemberFilter,
  RuntimeGroupMemberType,
  SearchResultOfGroupBan,
  SearchResultOfGroupMember,
  SearchResultOfGroupMemberApplication
} from './interfaces';

/** Returns a list of all available group avatars for the signed-in user. */
export function getAvailableAvatars(http: HttpClient): Promise<ServerResponse<{ [key: number]: string }>> {
  return http({
    method: 'GET',
    url: 'https://www.bungie.net/Platform/GroupV2/GetAvailableAvatars/'
  });
}

/** Returns a list of all available group themes. */
export function getAvailableThemes(http: HttpClient): Promise<ServerResponse<GroupTheme[]>> {
  return http({
    method: 'GET',
    url: 'https://www.bungie.net/Platform/GroupV2/GetAvailableThemes/'
  });
}

export interface GetUserClanInviteSettingParams {
  /** The Destiny membership type of the account we wish to access settings. */
  mType: BungieMembershipType;
}

/**
 * Gets the state of the user's clan invite preferences for a particular membership
 * type - true if they wish to be invited to clans, false otherwise.
 */
export function getUserClanInviteSetting(http: HttpClient, params: GetUserClanInviteSettingParams): Promise<ServerResponse<boolean>> {
  return http({
    method: 'GET',
    url: `https://www.bungie.net/Platform/GroupV2/GetUserClanInviteSetting/${params.mType}/`
  });
}

export interface SetUserClanInviteSettingParams {
  /** True to allow invites of this user to clans, false otherwise. */
  allowInvites: boolean;
  /** The Destiny membership type of linked account we are manipulating. */
  mType: BungieMembershipType;
}

/**
 * Sets the state of the user's clan invite preferences - true if they wish to be
 * invited to clans, false otherwise.
 */
export function setUserClanInviteSetting(http: HttpClient, params: SetUserClanInviteSettingParams): Promise<ServerResponse<number>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/SetUserClanInviteSetting/${params.mType}/${params.allowInvites}/`
  });
}

export interface GetRecommendedGroupsParams {
  /** Requested range in which to pull recommended groups */
  createDateRange: GroupDateRange;
  /** Type of groups requested */
  groupType: GroupType;
}

/**
 * Gets groups recommended for you based on the groups to whom those you follow
 * belong.
 */
export function getRecommendedGroups(http: HttpClient, params: GetRecommendedGroupsParams): Promise<ServerResponse<GroupV2Card[]>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/Recommended/${params.groupType}/${params.createDateRange}/`
  });
}

/** Search for Groups. */
export function groupSearch(http: HttpClient, body: GroupQuery): Promise<ServerResponse<GroupSearchResponse>> {
  return http({
    method: 'POST',
    url: 'https://www.bungie.net/Platform/GroupV2/Search/',
    body
  });
}

export interface GetGroupParams {
  /** Requested group's id. */
  groupId: string;
}

/** Get information about a specific group of the given ID. */
export function getGroup(http: HttpClient, params: GetGroupParams): Promise<ServerResponse<GroupResponse>> {
  return http({
    method: 'GET',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/`
  });
}

export interface GetGroupByNameParams {
  /** Exact name of the group to find. */
  groupName: string;
  /** Type of group to find. */
  groupType: GroupType;
}

/** Get information about a specific group with the given name and type. */
export function getGroupByName(http: HttpClient, params: GetGroupByNameParams): Promise<ServerResponse<GroupResponse>> {
  return http({
    method: 'GET',
    url: `https://www.bungie.net/Platform/GroupV2/Name/${params.groupName}/${params.groupType}/`
  });
}

export interface GetGroupOptionalConversationsParams {
  /** Requested group's id. */
  groupId: string;
}

/** Gets a list of available optional conversation channels and their settings. */
export function getGroupOptionalConversations(http: HttpClient, params: GetGroupOptionalConversationsParams): Promise<ServerResponse<GroupOptionalConversation[]>> {
  return http({
    method: 'GET',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/OptionalConversations/`
  });
}

/** Create a new group. */
export function createGroup(http: HttpClient, body: GroupAction): Promise<ServerResponse<GroupCreationResponse>> {
  return http({
    method: 'POST',
    url: 'https://www.bungie.net/Platform/GroupV2/Create/',
    body
  });
}

export interface EditGroupParams {
  /** Group ID of the group to edit. */
  groupId: string;
}

/**
 * Edit an existing group. You must have suitable permissions in the group to
 * perform this operation. This latest revision will only edit the fields you pass
 * in - pass null for properties you want to leave unaltered.
 */
export function editGroup(http: HttpClient, params: EditGroupParams, body: GroupEditAction): Promise<ServerResponse<number>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Edit/`,
    body
  });
}

export interface EditClanBannerParams {
  /** Group ID of the group to edit. */
  groupId: string;
}

/**
 * Edit an existing group's clan banner. You must have suitable permissions in the
 * group to perform this operation. All fields are required.
 */
export function editClanBanner(http: HttpClient, params: EditClanBannerParams, body: ClanBanner): Promise<ServerResponse<number>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/EditClanBanner/`,
    body
  });
}

export interface EditFounderOptionsParams {
  /** Group ID of the group to edit. */
  groupId: string;
}

/**
 * Edit group options only available to a founder. You must have suitable
 * permissions in the group to perform this operation.
 */
export function editFounderOptions(http: HttpClient, params: EditFounderOptionsParams, body: GroupOptionsEditAction): Promise<ServerResponse<number>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/EditFounderOptions/`,
    body
  });
}

export interface AddOptionalConversationParams {
  /** Group ID of the group to edit. */
  groupId: string;
}

/**
 * Add a new optional conversation/chat channel. Requires admin permissions to the
 * group.
 */
export function addOptionalConversation(http: HttpClient, params: AddOptionalConversationParams, body: GroupOptionalConversationAddRequest): Promise<ServerResponse<string>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/OptionalConversations/Add/`,
    body
  });
}

export interface EditOptionalConversationParams {
  /** Conversation Id of the channel being edited. */
  conversationId: string;
  /** Group ID of the group to edit. */
  groupId: string;
}

/**
 * Edit the settings of an optional conversation/chat channel. Requires admin
 * permissions to the group.
 */
export function editOptionalConversation(http: HttpClient, params: EditOptionalConversationParams, body: GroupOptionalConversationEditRequest): Promise<ServerResponse<string>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/OptionalConversations/Edit/${params.conversationId}/`,
    body
  });
}

export interface GetMembersOfGroupParams {
  /** Page number (starting with 1). Each page has a fixed size of 50 items per page. */
  currentpage: number;
  /** The ID of the group. */
  groupId: string;
  /** Filter out other member types. Use None for all members. */
  memberType?: RuntimeGroupMemberType;
  /**
   * The name fragment upon which a search should be executed for members with
   * matching display or unique names.
   */
  nameSearch?: string;
}

/** Get the list of members in a given group. */
export function getMembersOfGroup(http: HttpClient, params: GetMembersOfGroupParams): Promise<ServerResponse<SearchResultOfGroupMember>> {
  return http({
    method: 'GET',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/`,
    params: {
      memberType: params.memberType,
      nameSearch: params.nameSearch
    }
  });
}

export interface GetAdminsAndFounderOfGroupParams {
  /** Page number (starting with 1). Each page has a fixed size of 50 items per page. */
  currentpage: number;
  /** The ID of the group. */
  groupId: string;
}

/** Get the list of members in a given group who are of admin level or higher. */
export function getAdminsAndFounderOfGroup(http: HttpClient, params: GetAdminsAndFounderOfGroupParams): Promise<ServerResponse<SearchResultOfGroupMember>> {
  return http({
    method: 'GET',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/AdminsAndFounder/`
  });
}

export interface EditGroupMembershipParams {
  /** ID of the group to which the member belongs. */
  groupId: string;
  /** Membership ID to modify. */
  membershipId: string;
  /** Membership type of the provide membership ID. */
  membershipType: BungieMembershipType;
  /** New membertype for the specified member. */
  memberType: RuntimeGroupMemberType;
}

/**
 * Edit the membership type of a given member. You must have suitable permissions
 * in the group to perform this operation.
 */
export function editGroupMembership(http: HttpClient, params: EditGroupMembershipParams): Promise<ServerResponse<number>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/${params.membershipType}/${params.membershipId}/SetMembershipType/${params.memberType}/`
  });
}

export interface KickMemberParams {
  /** Group ID to kick the user from. */
  groupId: string;
  /** Membership ID to kick. */
  membershipId: string;
  /** Membership type of the provided membership ID. */
  membershipType: BungieMembershipType;
}

/**
 * Kick a member from the given group, forcing them to reapply if they wish to re-
 * join the group. You must have suitable permissions in the group to perform this
 * operation.
 */
export function kickMember(http: HttpClient, params: KickMemberParams): Promise<ServerResponse<GroupMemberLeaveResult>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/${params.membershipType}/${params.membershipId}/Kick/`
  });
}

export interface BanMemberParams {
  /** Group ID that has the member to ban. */
  groupId: string;
  /** Membership ID of the member to ban from the group. */
  membershipId: string;
  /** Membership type of the provided membership ID. */
  membershipType: BungieMembershipType;
}

/**
 * Bans the requested member from the requested group for the specified period of
 * time.
 */
export function banMember(http: HttpClient, params: BanMemberParams, body: GroupBanRequest): Promise<ServerResponse<number>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/${params.membershipType}/${params.membershipId}/Ban/`,
    body
  });
}

export interface UnbanMemberParams {
  groupId: string;
  /** Membership ID of the member to unban from the group */
  membershipId: string;
  /** Membership type of the provided membership ID. */
  membershipType: BungieMembershipType;
}

/** Unbans the requested member, allowing them to re-apply for membership. */
export function unbanMember(http: HttpClient, params: UnbanMemberParams): Promise<ServerResponse<number>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/${params.membershipType}/${params.membershipId}/Unban/`
  });
}

export interface GetBannedMembersOfGroupParams {
  /** Page number (starting with 1). Each page has a fixed size of 50 entries. */
  currentpage: number;
  /** Group ID whose banned members you are fetching */
  groupId: string;
}

/**
 * Get the list of banned members in a given group. Only accessible to group Admins
 * and above. Not applicable to all groups. Check group features.
 */
export function getBannedMembersOfGroup(http: HttpClient, params: GetBannedMembersOfGroupParams): Promise<ServerResponse<SearchResultOfGroupBan>> {
  return http({
    method: 'GET',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Banned/`
  });
}

export interface AbdicateFoundershipParams {
  /** The new founder for this group. Must already be a group admin. */
  founderIdNew: string;
  /** The target group id. */
  groupId: string;
  /** Membership type of the provided founderIdNew. */
  membershipType: BungieMembershipType;
}

/**
 * An administrative method to allow the founder of a group or clan to give up
 * their position to another admin permanently.
 */
export function abdicateFoundership(http: HttpClient, params: AbdicateFoundershipParams): Promise<ServerResponse<boolean>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Admin/AbdicateFoundership/${params.membershipType}/${params.founderIdNew}/`
  });
}

export interface RequestGroupMembershipParams {
  /** ID of the group you would like to join. */
  groupId: string;
  /** MembershipType of the account to use when joining. */
  membershipType: BungieMembershipType;
}

/** Request permission to join the given group. */
export function requestGroupMembership(http: HttpClient, params: RequestGroupMembershipParams, body: GroupApplicationRequest): Promise<ServerResponse<GroupApplicationResponse>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/Apply/${params.membershipType}/`,
    body
  });
}

export interface GetPendingMembershipsParams {
  /** Page number (starting with 1). Each page has a fixed size of 50 items per page. */
  currentpage: number;
  /** ID of the group. */
  groupId: string;
}

/**
 * Get the list of users who are awaiting a decision on their application to join a
 * given group. Modified to include application info.
 */
export function getPendingMemberships(http: HttpClient, params: GetPendingMembershipsParams): Promise<ServerResponse<SearchResultOfGroupMemberApplication>> {
  return http({
    method: 'GET',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/Pending/`
  });
}

export interface GetInvitedIndividualsParams {
  /** Page number (starting with 1). Each page has a fixed size of 50 items per page. */
  currentpage: number;
  /** ID of the group. */
  groupId: string;
}

/** Get the list of users who have been invited into the group. */
export function getInvitedIndividuals(http: HttpClient, params: GetInvitedIndividualsParams): Promise<ServerResponse<SearchResultOfGroupMemberApplication>> {
  return http({
    method: 'GET',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/InvitedIndividuals/`
  });
}

export interface RescindGroupMembershipParams {
  /** ID of the group. */
  groupId: string;
  /** MembershipType of the account to leave. */
  membershipType: BungieMembershipType;
}

/**
 * Rescind your application to join the given group or leave the group if you are
 * already a member..
 */
export function rescindGroupMembership(http: HttpClient, params: RescindGroupMembershipParams): Promise<ServerResponse<GroupMemberLeaveResult>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/Rescind/${params.membershipType}/`
  });
}

export interface ApproveAllPendingParams {
  /** ID of the group. */
  groupId: string;
}

/** Approve all of the pending users for the given group. */
export function approveAllPending(http: HttpClient, params: ApproveAllPendingParams, body: GroupApplicationRequest): Promise<ServerResponse<EntityActionResult[]>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/ApproveAll/`,
    body
  });
}

export interface DenyAllPendingParams {
  /** ID of the group. */
  groupId: string;
}

/** Deny all of the pending users for the given group. */
export function denyAllPending(http: HttpClient, params: DenyAllPendingParams, body: GroupApplicationRequest): Promise<ServerResponse<EntityActionResult[]>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/DenyAll/`,
    body
  });
}

export interface ApprovePendingForListParams {
  /** ID of the group. */
  groupId: string;
}

/** Approve all of the pending users for the given group. */
export function approvePendingForList(http: HttpClient, params: ApprovePendingForListParams, body: GroupApplicationListRequest): Promise<ServerResponse<EntityActionResult[]>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/ApproveList/`,
    body
  });
}

export interface ApprovePendingParams {
  /** ID of the group. */
  groupId: string;
  /** The membership id being approved. */
  membershipId: string;
  /** Membership type of the supplied membership ID. */
  membershipType: BungieMembershipType;
}

/**
 * Approve the given membershipId to join the group/clan as long as they have
 * applied.
 */
export function approvePending(http: HttpClient, params: ApprovePendingParams, body: GroupApplicationRequest): Promise<ServerResponse<boolean>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/Approve/${params.membershipType}/${params.membershipId}/`,
    body
  });
}

export interface DenyPendingForListParams {
  /** ID of the group. */
  groupId: string;
}

/** Deny all of the pending users for the given group that match the passed-in . */
export function denyPendingForList(http: HttpClient, params: DenyPendingForListParams, body: GroupApplicationListRequest): Promise<ServerResponse<EntityActionResult[]>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/DenyList/`,
    body
  });
}

export interface GetGroupsForMemberParams {
  /** Filter apply to list of joined groups. */
  filter: GroupsForMemberFilter;
  /** Type of group the supplied member founded. */
  groupType: GroupType;
  /** Membership ID to for which to find founded groups. */
  membershipId: string;
  /** Membership type of the supplied membership ID. */
  membershipType: BungieMembershipType;
}

/** Get information about the groups that a given member has joined. */
export function getGroupsForMember(http: HttpClient, params: GetGroupsForMemberParams): Promise<ServerResponse<GroupMembershipSearchResponse>> {
  return http({
    method: 'GET',
    url: `https://www.bungie.net/Platform/GroupV2/User/${params.membershipType}/${params.membershipId}/${params.filter}/${params.groupType}/`
  });
}

export interface GetPotentialGroupsForMemberParams {
  /** Filter apply to list of potential joined groups. */
  filter: GroupPotentialMemberStatus;
  /** Type of group the supplied member applied. */
  groupType: GroupType;
  /** Membership ID to for which to find applied groups. */
  membershipId: string;
  /** Membership type of the supplied membership ID. */
  membershipType: BungieMembershipType;
}

/**
 * Get information about the groups that a given member has applied to or been
 * invited to.
 */
export function getPotentialGroupsForMember(http: HttpClient, params: GetPotentialGroupsForMemberParams): Promise<ServerResponse<GroupPotentialMembershipSearchResponse>> {
  return http({
    method: 'GET',
    url: `https://www.bungie.net/Platform/GroupV2/User/Potential/${params.membershipType}/${params.membershipId}/${params.filter}/${params.groupType}/`
  });
}

export interface IndividualGroupInviteParams {
  /** ID of the group you would like to join. */
  groupId: string;
  /** Membership id of the account being invited. */
  membershipId: string;
  /** MembershipType of the account being invited. */
  membershipType: BungieMembershipType;
}

/** Invite a user to join this group. */
export function individualGroupInvite(http: HttpClient, params: IndividualGroupInviteParams, body: GroupApplicationRequest): Promise<ServerResponse<GroupApplicationResponse>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/IndividualInvite/${params.membershipType}/${params.membershipId}/`,
    body
  });
}

export interface IndividualGroupInviteCancelParams {
  /** ID of the group you would like to join. */
  groupId: string;
  /** Membership id of the account being cancelled. */
  membershipId: string;
  /** MembershipType of the account being cancelled. */
  membershipType: BungieMembershipType;
}

/** Cancels a pending invitation to join a group. */
export function individualGroupInviteCancel(http: HttpClient, params: IndividualGroupInviteCancelParams): Promise<ServerResponse<GroupApplicationResponse>> {
  return http({
    method: 'POST',
    url: `https://www.bungie.net/Platform/GroupV2/${params.groupId}/Members/IndividualInviteCancel/${params.membershipType}/${params.membershipId}/`
  });
}
