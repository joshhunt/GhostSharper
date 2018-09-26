/**
 * Bungie.Net API
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * OpenAPI spec version: 2.3.2
 * Contact: support@bungie.com
 *
 * NOTE: This class is auto generated by the bungie-api-dart code generator program.
 * https://github.com/marquesinijatinha/bungie-api-dart
 * Do not edit these files manually.
 */

import 'dart:async';
import '../http.dart';

import '../common.dart';
import './interfaces.dart';

abstract class GetBungieNetUserByIdParams {
  /** The requested Bungie.net membership id. */
  String id;
}

/** Loads a bungienet user by membership id. */
  Future<ServerResponse<GeneralUser>> getBungieNetUserById(HttpClient http, GetBungieNetUserByIdParams params) {
  return http.request(new HttpClientConfig(
    'GET',
    "https://www.bungie.net/Platform/User/GetBungieNetUserById/${params.id}/",
    null,
    null
    ));
}

abstract class SearchUsersParams {
  /** The search string. */
  String q;
}

/** Returns a list of possible users based on the search string */
  Future<ServerResponse<List<GeneralUser>>> searchUsers(HttpClient http, SearchUsersParams params) {
  return http.request(new HttpClientConfig(
    'GET',
    "https://www.bungie.net/Platform/User/SearchUsers/",
    {
      'q': params.q
    },
    null
    ));
}

/** Returns a list of all available user themes. */
  Future<ServerResponse<List<UserTheme>>> getAvailableThemes(HttpClient http) {
  return http.request(new HttpClientConfig(
    'GET',
    "https://www.bungie.net/Platform/User/GetAvailableThemes/",
    null,
    null
    ));
}

abstract class GetMembershipDataByIdParams {
  /** The membership ID of the target user. */
  String membershipId;
  /** Type of the supplied membership ID. */
  BungieMembershipType membershipType;
}

/**
 * Returns a list of accounts associated with the supplied membership ID and
 * membership type. This will include all linked accounts (even when hidden) if
 * supplied credentials permit it.
 */
  Future<ServerResponse<UserMembershipData>> getMembershipDataById(HttpClient http, GetMembershipDataByIdParams params) {
  return http.request(new HttpClientConfig(
    'GET',
    "https://www.bungie.net/Platform/User/GetMembershipsById/${params.membershipId}/${params.membershipType}/",
    null,
    null
    ));
}

/**
 * Returns a list of accounts associated with signed in user. This is useful for
 * OAuth implementations that do not give you access to the token response.
 */
  Future<ServerResponse<UserMembershipData>> getMembershipDataForCurrentUser(HttpClient http) {
  return http.request(new HttpClientConfig(
    'GET',
    "https://www.bungie.net/Platform/User/GetMembershipsForCurrentUser/",
    null,
    null
    ));
}

abstract class GetPartnershipsParams {
  /** The ID of the member for whom partnerships should be returned. */
  String membershipId;
}

/** Returns a user's linked Partnerships. */
  Future<ServerResponse<List<PublicPartnershipDetail>>> getPartnerships(HttpClient http, GetPartnershipsParams params) {
  return http.request(new HttpClientConfig(
    'GET',
    "https://www.bungie.net/Platform/User/${params.membershipId}/Partnerships/",
    null,
    null
    ));
}
