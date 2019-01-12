import 'destiny_historical_stats_value.dart';
import 'destiny_historical_stats_period_group.dart';

/**  */
class DestinyHistoricalStatsByPeriod{
	
	/**  */
	Map<String, DestinyHistoricalStatsValue> allTime;
	
	/**  */
	Map<String, DestinyHistoricalStatsValue> allTimeTier1;
	
	/**  */
	Map<String, DestinyHistoricalStatsValue> allTimeTier2;
	
	/**  */
	Map<String, DestinyHistoricalStatsValue> allTimeTier3;
	
	/**  */
	List<DestinyHistoricalStatsPeriodGroup> daily;
	
	/**  */
	List<DestinyHistoricalStatsPeriodGroup> monthly;
	DestinyHistoricalStatsByPeriod(
		this.allTime,
		this.allTimeTier1,
		this.allTimeTier2,
		this.allTimeTier3,
		this.daily,
		this.monthly,
	);

	static DestinyHistoricalStatsByPeriod fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyHistoricalStatsByPeriod(
				data['allTime'] != null ? Map<String, DestinyHistoricalStatsValue>.from(data['allTime'].map((k, v)=>MapEntry(k, DestinyHistoricalStatsValue.fromMap(v)))) : null,
				data['allTimeTier1'] != null ? Map<String, DestinyHistoricalStatsValue>.from(data['allTimeTier1'].map((k, v)=>MapEntry(k, DestinyHistoricalStatsValue.fromMap(v)))) : null,
				data['allTimeTier2'] != null ? Map<String, DestinyHistoricalStatsValue>.from(data['allTimeTier2'].map((k, v)=>MapEntry(k, DestinyHistoricalStatsValue.fromMap(v)))) : null,
				data['allTimeTier3'] != null ? Map<String, DestinyHistoricalStatsValue>.from(data['allTimeTier3'].map((k, v)=>MapEntry(k, DestinyHistoricalStatsValue.fromMap(v)))) : null,
				data['daily'] != null ? DestinyHistoricalStatsPeriodGroup.fromList(data['daily']) : null,
				data['monthly'] != null ? DestinyHistoricalStatsPeriodGroup.fromList(data['monthly']) : null,
		);
	}

	static List<DestinyHistoricalStatsByPeriod> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyHistoricalStatsByPeriod> list = new List();
    data.forEach((item) {
      list.add(DestinyHistoricalStatsByPeriod.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['allTime'] = this.allTime;
			data['allTimeTier1'] = this.allTimeTier1;
			data['allTimeTier2'] = this.allTimeTier2;
			data['allTimeTier3'] = this.allTimeTier3;
			data['daily'] = this.daily.map((item)=>item.toMap()).toList();
			data['monthly'] = this.monthly.map((item)=>item.toMap()).toList();
		return data;
	}
}