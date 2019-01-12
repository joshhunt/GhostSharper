
/**  */
class UserTheme{
	
	/**  */
	int userThemeId;
	
	/**  */
	String userThemeName;
	
	/**  */
	String userThemeDescription;
	UserTheme(
		this.userThemeId,
		this.userThemeName,
		this.userThemeDescription,
	);

	static UserTheme fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new UserTheme(
				data['userThemeId'],
				data['userThemeName'],
				data['userThemeDescription'],
		);
	}

	static List<UserTheme> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<UserTheme> list = new List();
    data.forEach((item) {
      list.add(UserTheme.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['userThemeId'] = this.userThemeId;
			data['userThemeName'] = this.userThemeName;
			data['userThemeDescription'] = this.userThemeDescription;
		return data;
	}
}