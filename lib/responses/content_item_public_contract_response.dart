import '../models/content_item_public_contract.dart';
class ContentItemPublicContractResponse{
    ContentItemPublicContract response;
    int errorCode;
    int throttleSeconds;
    String errorStatus;
    String message;
    Map<String, String> messageData;
    String detailedErrorTrace;

    ContentItemPublicContractResponse(
		ContentItemPublicContract this.response,
		int this.errorCode,
		int this.throttleSeconds,
		String this.errorStatus,
		String this.message,
		Map<String, String> this.messageData,
		String this.detailedErrorTrace,
	);

    static ContentItemPublicContractResponse fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new ContentItemPublicContractResponse(
				data['Response'] != null ? ContentItemPublicContract.fromMap(data['Response']) : null,
				data['ErrorCode'],
				data['ThrottleSeconds'],
				data['ErrorStatus'],
				data['Message'],
				data['MessageData'] != null ? Map<String, String>.from(data['MessageData'].map((k, v)=>MapEntry(k, v))) : null,
				data['DetailedErrorTrace'],
		);
	}

	static List<ContentItemPublicContractResponse> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<ContentItemPublicContractResponse> list = new List();
    data.forEach((item) {
      list.add(ContentItemPublicContractResponse.fromMap(item));
    });
    return list;
	}
}