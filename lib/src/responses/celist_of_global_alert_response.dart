import '../models/global_alert.dart';

import 'package:json_annotation/json_annotation.dart';
part 'celist_of_global_alert_response.g.dart';

/** Look at the Response property for more information about the nature of this response */
@JsonSerializable()
class CEListOfGlobalAlertResponse{
	
	/**  */
	@JsonKey(name:'Response')
	List<GlobalAlert> response;
	
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
	CEListOfGlobalAlertResponse({
		List<GlobalAlert> this.response,
		int this.errorCode,
		int this.throttleSeconds,
		String this.errorStatus,
		String this.message,
		Map<String, String> this.messageData,
		String this.detailedErrorTrace,
	});

	factory CEListOfGlobalAlertResponse.fromJson(Map<String, dynamic> json) => _$CEListOfGlobalAlertResponseFromJson(json);
	

	Map<String, dynamic> toJson() => _$CEListOfGlobalAlertResponseToJson(this);
}