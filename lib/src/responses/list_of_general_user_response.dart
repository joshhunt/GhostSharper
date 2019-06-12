import '../models/general_user.dart';

import 'package:json_annotation/json_annotation.dart';
part 'list_of_general_user_response.g.dart';

/** Look at the Response property for more information about the nature of this response */
@JsonSerializable()
class ListOfGeneralUserResponse{
	
	/**  */
	@JsonKey(name:'Response')
	List<GeneralUser> response;
	
	/**  */
	@JsonKey(name:'ErrorCode')
	int errorCode;
	
	/**  */
	@JsonKey(name:'ThrottleSeconds')
	int throttleSeconds;
	
	/**  */
	@JsonKey(name:'ErrorStatus')
	String errorStatus;
	
	/**  */
	@JsonKey(name:'Message')
	String message;
	
	/**  */
	@JsonKey(name:'MessageData')
	Map<String, String> messageData;
	
	/**  */
	@JsonKey(name:'DetailedErrorTrace')
	String detailedErrorTrace;
	ListOfGeneralUserResponse({
		List<GeneralUser> this.response,
		int this.errorCode,
		int this.throttleSeconds,
		String this.errorStatus,
		String this.message,
		Map<String, String> this.messageData,
		String this.detailedErrorTrace,
	});

	factory ListOfGeneralUserResponse.fromJson(Map<String, dynamic> json) => _$ListOfGeneralUserResponseFromJson(json);
	

	Map<String, dynamic> toJson() => _$ListOfGeneralUserResponseToJson(this);
}