import 'destiny_historical_stats_value_pair.dart';

/**  */
class DestinyHistoricalStatsValue{
	
	/** Unique ID for this stat */
	String statId;
	
	/** Basic stat value. */
	DestinyHistoricalStatsValuePair basic;
	
	/** Per game average for the statistic, if applicable */
	DestinyHistoricalStatsValuePair pga;
	
	/** Weighted value of the stat if a weight greater than 1 has been assigned. */
	DestinyHistoricalStatsValuePair weighted;
	
	/** When a stat represents the best, most, longest, fastest or some other personal best, the actual activity ID where that personal best was established is available on this property. */
	String activityId;
	DestinyHistoricalStatsValue(
		this.statId,
		this.basic,
		this.pga,
		this.weighted,
		this.activityId,
	);

	static DestinyHistoricalStatsValue fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyHistoricalStatsValue(
				data['statId'],
				data['basic'] != null ? DestinyHistoricalStatsValuePair.fromMap(data['basic']) : null,
				data['pga'] != null ? DestinyHistoricalStatsValuePair.fromMap(data['pga']) : null,
				data['weighted'] != null ? DestinyHistoricalStatsValuePair.fromMap(data['weighted']) : null,
				data['activityId'],
		);
	}

	static List<DestinyHistoricalStatsValue> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyHistoricalStatsValue> list = new List();
    data.forEach((item) {
      list.add(DestinyHistoricalStatsValue.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['statId'] = this.statId;
			data['basic'] = this.basic;
			data['pga'] = this.pga;
			data['weighted'] = this.weighted;
			data['activityId'] = this.activityId;
		return data;
	}
}