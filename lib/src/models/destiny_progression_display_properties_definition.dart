
import 'package:json_annotation/json_annotation.dart';
part 'destiny_progression_display_properties_definition.g.dart';

/**  */
@JsonSerializable()
class DestinyProgressionDisplayPropertiesDefinition{
	
	/** When progressions show your "experience" gained, that bar has units (i.e. "Experience", "Bad Dudes Snuffed Out", whatever). This is the localized string for that unit of measurement. */
	@JsonKey(name:'displayUnitsName')
	String displayUnitsName;
	
	/**  */
	@JsonKey(name:'description')
	String description;
	
	/**  */
	@JsonKey(name:'name')
	String name;
	
	/** Note that "icon" is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition's icon was a big picture of a book.
But usually, it will be a small square image that you can use as... well, an icon.
They are currently represented as 96px x 96px images. */
	@JsonKey(name:'icon')
	String icon;
	
	/**  */
	@JsonKey(name:'hasIcon')
	bool hasIcon;
	DestinyProgressionDisplayPropertiesDefinition();

	factory DestinyProgressionDisplayPropertiesDefinition.fromJson(Map<String, dynamic> json) => _$DestinyProgressionDisplayPropertiesDefinitionFromJson(json);
	
	Map<String, dynamic> toJson() => _$DestinyProgressionDisplayPropertiesDefinitionToJson(this);
}